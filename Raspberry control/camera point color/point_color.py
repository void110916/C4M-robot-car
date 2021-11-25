import cv2
def mouse_pos(event,x,y,flags,param):
    global mx,my
    mx,my=x,y
    

if __name__=="__main__":
    cap=cv2.VideoCapture(0,cv2.CAP_DSHOW)
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT,720)
    cap.set(cv2.CAP_PROP_FRAME_WIDTH,1280)
    cap.set(cv2.CAP_PROP_FPS,30)
    cv2.namedWindow("raw",cv2.WINDOW_KEEPRATIO)
    # ret,img=cap.read()
    cv2.setMouseCallback("raw",mouse_pos)
    mx=my=0
    while True:
        ret,img=cap.read()
        if ret:
            hsv=cv2.cvtColor(img,cv2.COLOR_BGR2HLS)
            cv2.putText(img,f"H:{hsv[my,mx,0]:3},L:{hsv[my,mx,1]:3},S:{hsv[my,mx,2]:3}",(10,30),cv2.FONT_HERSHEY_SIMPLEX,1,(0,255,0),2)
            cv2.imshow("raw",img)
            k=cv2.waitKey(1)
            if k==ord('q'):
                break