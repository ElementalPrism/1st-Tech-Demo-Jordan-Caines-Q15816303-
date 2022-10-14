using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBarrierScript : MonoBehaviour
{
    public Transform MainCam;
    public Transform Screen1, Screen2, Screen3, Screen4, Screen5, Screen6;
    public Transform BarrierPos1, BarrierPos2, BarrierPos3, BarrierPos4, BarrierPos5, BarrierPos6, BarrierPos7;
    public float MoveSpeed;
    public static Vector2 NewPos;

    
    // Start is called before the first frame update
    void Start()
    {
        NewPos = BarrierPos1.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, NewPos, MoveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        
        
       /* 
        if(MainCam.position == Screen1.position)
        {

        }
        */

        if(MainCam.position == Screen2.position)
        {
            //Moves camera to screen 1
            Camera_Script.ScreenNum = 1;
            NewPos = BarrierPos1.position;
            RightBarrierScript.NewPos = BarrierPos2.position;

        }

        if(MainCam.position == Screen3.position)
        {
            Camera_Script.ScreenNum = 2;
            NewPos = BarrierPos2.position;
            RightBarrierScript.NewPos = BarrierPos3.position;
        }

        if(MainCam.position == Screen4.position)
        {
            Camera_Script.ScreenNum = 3;
            NewPos = BarrierPos3.position;
            RightBarrierScript.NewPos = BarrierPos4.position;
        }

        if(MainCam.position == Screen5.position)
        {
            Camera_Script.ScreenNum = 4;
            NewPos = BarrierPos4.position;
            RightBarrierScript.NewPos = BarrierPos5.position;
        }
        
        if(MainCam.position == Screen6.position)
        {
            Camera_Script.ScreenNum = 5;
            NewPos = BarrierPos5.position;
            RightBarrierScript.NewPos = BarrierPos6.position;
        }

    }








}
