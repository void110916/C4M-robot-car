from enum import Enum
from typing import Counter
import numpy as np
import cv2
import ctypes
# feature :
# one frame spilt to 2 frame, and check if the color cross to the other frame 


# OpenCV hls色域範圍
# H: 360' / 2
# S: 100% * 255
# V: 100% * 255
frame_h=720
frame_w=1280
split=0.5
split_gap=int(frame_w*split)
class enum_side(Enum):
    R=0
    B=1
    G=2
    O=3
def hls2cvhls(arr):
    return np.array([arr[0]//2,arr[1]*2.55,arr[2]*2.55])
def case1_detect(l_filter_side,r_filter_side,gap):
    # print(l_filter_side)
    if(l_filter_side[1]>gap):
        cv2.putText(img,f"left over",(10,30),cv2.FONT_HERSHEY_SIMPLEX,1,(0,0,255),2)
        
    if(r_filter_side[0]<gap):
        cv2.putText(img,f"right over",(10,30),cv2.FONT_HERSHEY_SIMPLEX,1,(0,0,255),2)

def case1(graph):   #hls
    
    # test color
    red_H=hls2cvhls(np.array([359,100,100]))
    red_H_2=hls2cvhls(np.array([10,100,100]))
    red_L=hls2cvhls(np.array([300,0,20]))
    red_L_2=hls2cvhls(np.array([0,0,20]))
    blue_H=hls2cvhls(np.array([220,100,100]))
    blue_L=hls2cvhls(np.array([182,40,40]))
    green_H=hls2cvhls(np.array([179,100,100]))
    green_L=hls2cvhls(np.array([84,22,11]))
    orange_H=hls2cvhls(np.array([20,100,100]))
    orange_L=hls2cvhls(np.array([11,0,40]))
    # run color
    # red_H=np.array([180,220,220])
    # red_H_2=np.array([5,220,220])
    # red_L=np.array([175,170,170])
    # red_L_2=np.array([0,170,170])
    # blue_H=np.array([110,250,220])
    # blue_L=np.array([107,170,170])
    # green_H=np.array([51,100,170])
    # green_L=np.array([46,70,120])
    # orange_H=np.array([15,170,255])
    # orange_L=np.array([10,140,170])
    red_filer=cv2.inRange(graph,red_L,red_H)  #(355,79%*255,96%*255)+-(4,11,11)
    red_filer=cv2.bitwise_or(red_filer,cv2.inRange(graph,red_L_2,red_H_2))
    blue_filer=cv2.inRange(graph,blue_L,blue_H)   #(198,100,96)+-(4,20,16)
    green_filer=cv2.inRange(graph,green_L,green_H)  #(88,83,75)+-(4,15,15)
    orange_filer=cv2.inRange(graph,orange_L,orange_H) #(40,100,100)+-(3,20,20)
    kern=np.ones((5,5),np.int8)
    # red_filer=cv2.morphologyEx(red_filer,cv2.MORPH_OPEN,kern)
    # red_filer=cv2.morphologyEx(red_filer,cv2.MORPH_CLOSE,kern)
    # kern=np.ones((3,3),np.int8)
    # blue_filer=cv2.morphologyEx(blue_filer,cv2.MORPH_OPEN,kern)
    # kern=np.ones((3,3),np.int8)
    # green_filer=cv2.morphologyEx(green_filer,cv2.MORPH_OPEN,kern)
    # kern=np.ones((3,3),np.int8)
    # orange_filer=cv2.morphologyEx(orange_filer,cv2.MORPH_OPEN,kern)
    filers=(red_filer,blue_filer,green_filer,orange_filer)
    sides=np.array(((split_gap,split_gap),(split_gap,split_gap),(split_gap,split_gap),(split_gap,split_gap)))
    for filer in zip(filers,('R','B','G','O'),sides):
        filer_v,filer_n,filer_s=filer
        contours,_=cv2.findContours(filer_v,cv2.RETR_EXTERNAL,cv2.CHAIN_APPROX_SIMPLE)
        
        for cont in contours:
            if cv2.contourArea(cont)<(frame_h*frame_w/100):
                continue
            if cv2.contourArea(cont)>(frame_h*frame_w/30):
                continue
            
            area=cv2.minAreaRect(cont)
            box = np.int0(cv2.boxPoints(area))
            for b in box:
                cv2.putText(img,f"{b[0],b[1]}",(b[0],b[1]),cv2.FONT_HERSHEY_SIMPLEX,1,(0,255,255),2)
            
            
            
            cv2.drawContours(img, cont, -1, (255, 0, 255), 2)
            # x,y,w,h=cv2.boundingRect(cont)
            # cv2.rectangle(img,(x,y),(x+w,y+h),(0 ,255,0),1)
            
            center,side,ang=area
            center=np.array(center,np.int0)
            side=np.array(side,np.int0)
            # tuple((center-side/2).astype(np.int8))
            cv2.putText(img,f"{filer_n},{ang:3.1f}",tuple(center),cv2.FONT_HERSHEY_SIMPLEX,1,(0,255,0),2)
            filer_s[1]=max(filer_s[1],box[:,0].max())
            filer_s[0]=min(filer_s[0],box[:,0].min())
    case1_detect(sides[enum_side.G.value],sides[enum_side.R.value],split_gap)
        
            
    cv2.imshow("red",red_filer)
    cv2.imshow("green",green_filer)
    cv2.imshow("blue",blue_filer)
    cv2.imshow("orange",orange_filer)
if __name__=="__main__":
    cap = cv2.VideoCapture(0,cv2.CAP_DSHOW)
    
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT,frame_h)
    cap.set(cv2.CAP_PROP_FRAME_WIDTH,frame_w)
    cap.set(cv2.CAP_PROP_FPS,30)
    cv2.namedWindow("raw",cv2.WINDOW_FREERATIO)
    cv2.namedWindow("red",cv2.WINDOW_FREERATIO)
    cv2.namedWindow("green",cv2.WINDOW_FREERATIO)
    cv2.namedWindow("blue",cv2.WINDOW_FREERATIO)
    cv2.namedWindow("orange",cv2.WINDOW_FREERATIO)

    while True:
        rat,img=cap.read()
        if rat:
            
            hls=cv2.cvtColor(img,cv2.COLOR_BGR2HLS)
            case1(hls)
            cv2.imshow("raw",img)
        k=cv2.waitKey(1)
        if k==ord('q'):
            break


    