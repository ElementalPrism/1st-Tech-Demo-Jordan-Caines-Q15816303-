using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collapsing_Platform_Script : MonoBehaviour
{

    public float Timer;
    public float TimeToFall;
    public float PlatformRespawnNow;
    public SpriteRenderer PlatformSprite;
    public BoxCollider2D PlatformHitBox;
    public BoxCollider2D Platform;
    public Animator FallingPlatform;
    


    // Update is called once per frame
    void Update()
    {
        Timer += 1;


        if (Timer > PlatformRespawnNow)
        {
            //PlatformSprite.enabled = true;
            PlatformHitBox.enabled = true;
            Platform.enabled = true;
            FallingPlatform.SetBool("IsTriggered", false);
        }

        if (Timer > TimeToFall && Timer < PlatformRespawnNow)
        {

            //PlatformSprite.enabled = false;
            
            PlatformHitBox.enabled = false;
            Platform.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Timer = 0;
       
        FallingPlatform.SetBool("IsTriggered", true);
    }



}
