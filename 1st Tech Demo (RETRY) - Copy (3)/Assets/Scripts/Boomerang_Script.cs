using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang_Script : MonoBehaviour
{
    public float BoomerangSpeed;
    public float BoomerangRange;
    public static float Timer;
    public float ShowTimer;
    public float BoomerangReturn;
    public Transform PlayerPos;
    public static bool Returned;

    public SpriteRenderer BoomerangSprite;
    public BoxCollider2D BoomerangHitBox;
    public Animator PlayerThrow;



    Vector2 NewPos;
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Timer = ShowTimer;

        BoomerangSprite.enabled = false;
        BoomerangHitBox.enabled = false;
        NewPos = PlayerPos.position;
        transform.position = PlayerPos.position;
    }

    // Update is called once per frame
    void Update()
    {

        Timer += 1;
        ShowTimer = Timer;

        if (Player_Script.BoomerangFire == true)
        {
            BoomerangSprite.enabled = true;
            BoomerangHitBox.enabled = true;

        }
        
        
        if(Player_Script.BoomerangMoving == true)
        {
            if (Player_Script.PlayerDirection.flipX == false)
            {
                Timer = 0;
                NewPos.x = transform.position.x + BoomerangRange;

                Player_Script.BoomerangMoving = false;
            }

            if (Player_Script.PlayerDirection.flipX == true)
            {
                Timer = 0;
                NewPos.x = transform.position.x - BoomerangRange;

                Player_Script.BoomerangMoving = false;
            }
        }

        
        if(Timer > BoomerangReturn)
        {
            NewPos = PlayerPos.position;
            Returned = true;
        }
        
        if(transform.position.x == NewPos.x)
        {
            PlayerThrow.SetBool("BoomerangThrow", false);
        }
        
        if(transform.position == PlayerPos.position)
        {
            if (Returned == true)
            {
                BoomerangSprite.enabled = false;
                BoomerangHitBox.enabled = false;
                Returned = false;
                Player_Script.BoomerangFire = false;
            }

               

        }
       

        
        
        transform.position = Vector2.MoveTowards(transform.position, NewPos, BoomerangSpeed * Time.deltaTime);



    }
}
