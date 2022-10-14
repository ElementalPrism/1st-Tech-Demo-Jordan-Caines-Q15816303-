using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBarrierScript : MonoBehaviour
{

    public Transform MainCam;
    public Transform Screen1, Screen2, Screen3, Screen4, Screen5, Screen6;
    public Transform BarrierPos1, BarrierPos2, BarrierPos3, BarrierPos4, BarrierPos5, BarrierPos6, BarrierPos7;
    public float MoveSpeed;
    public static Vector2 NewPos;



   // Vector2 MainCamPos;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        NewPos = BarrierPos2.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, NewPos, MoveSpeed * Time.deltaTime);
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if(MainCam.position == Screen1.position)
        {
            //moves the camera to screen2

            Camera_Script.ScreenNum = 2;
            NewPos = BarrierPos3.position;
            LeftBarrierScript.NewPos = BarrierPos2.position;
        }

        if(MainCam.position == Screen2.position)
        {
            Camera_Script.ScreenNum = 3;
            NewPos = BarrierPos4.position;
            LeftBarrierScript.NewPos = BarrierPos3.position;
        }
        
        if(MainCam.position == Screen3.position)
        {
            Camera_Script.ScreenNum = 4;
            NewPos = BarrierPos5.position;
            LeftBarrierScript.NewPos = BarrierPos4.position;
        }

        if(MainCam.position == Screen4.position)
        {
            Camera_Script.ScreenNum = 5;
            NewPos = BarrierPos6.position;
            LeftBarrierScript.NewPos = BarrierPos5.position;
        }

        if(MainCam.position == Screen5.position)
        {
            Camera_Script.ScreenNum = 6;
            NewPos = BarrierPos7.position;
            LeftBarrierScript.NewPos = BarrierPos6.position;
        }


    }




     
        



}
