using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder_Script : MonoBehaviour
{
    public static bool NearLadder;
    public bool LadderCheck;
    public Rigidbody2D GravitySwitch;
    int GravityOn = 1;
    int GravityOff = 0;


    // Start is called before the first frame update
    void Start()
    {
        NearLadder = false;
        LadderCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        NearLadder = true;
        LadderCheck = true;
        GravitySwitch.gravityScale = GravityOff;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        NearLadder = false;
        LadderCheck = false;
        GravitySwitch.gravityScale = GravityOn;
    }





}
