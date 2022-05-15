from enum import Enum
from typing import Counter
import numpy as np
import cv2

frame_h=720
frame_w=1280
cube_on_floar=3
def case2(graph):
    
    

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
            
            # hls=cv2.cvtColor(img,cv2.COLOR_BGR2HLS)
            case2(img)
            cv2.imshow("raw",img)
        k=cv2.waitKey(1)
        if k==ord('q'):
            break