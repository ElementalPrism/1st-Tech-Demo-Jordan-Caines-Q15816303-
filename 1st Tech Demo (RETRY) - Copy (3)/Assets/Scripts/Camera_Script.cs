using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{

    public Transform Screen1, Screen2, Screen3, Screen4, Screen5, Screen6;
    public float CameraSpeed;
    public static int ScreenNum;
    public int ShowScreen;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Screen1.position;
        ScreenNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ShowScreen = ScreenNum;

        if(ScreenNum == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Screen1.position, CameraSpeed * Time.deltaTime);
        }

        if (ScreenNum == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, Screen2.position, CameraSpeed * Time.deltaTime);
        }

        if (ScreenNum == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, Screen3.position, CameraSpeed * Time.deltaTime);
        }

        if (ScreenNum == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, Screen4.position, CameraSpeed * Time.deltaTime);
        }

        if (ScreenNum == 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, Screen5.position, CameraSpeed * Time.deltaTime);
        }

        if (ScreenNum == 6)
        {
            transform.position = Vector3.MoveTowards(transform.position, Screen6.position, CameraSpeed * Time.deltaTime);
        }

    }
















   /*
      NewPos = Screen1.position;
       NewPos.z = -NewPos.z;
      ScreenNum = 1;
     transform.position = Screen1.position;
     */
}
   /*ShowScreen = ScreenNum;


        
        if(ScreenNum == 1)
        {
            NewX = Screen1.position;
            NewPos.x = NewX.x;
            PlayerY = PlayerPos.position;
            NewPos.y = PlayerY.y;
        }

        if (ScreenNum == 2)
        {
            NewX = Screen2.position;
            NewPos.x = NewX.x;
            PlayerY = PlayerPos.position;
            NewPos.y = PlayerY.y;
        }
        

        transform.position = Vector2.MoveTowards(transform.position, NewPos, CameraSpeed * Time.deltaTime);
        */