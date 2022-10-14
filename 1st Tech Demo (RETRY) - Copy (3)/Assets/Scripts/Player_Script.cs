using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    public Rigidbody2D Controller;
    public SpriteRenderer PlayerSprite;
    public static SpriteRenderer PlayerDirection;
    public float JumpSpeed;
    public LayerMask RayCastLayer;
    public float RayCastSize;
    RaycastHit2D RayCastFire;
    public bool Grounded;
    public bool JetpackDepleted;
    float SidewaysMovement;
    public float MovementSpeed;
    public float FuelMax;
    public float LadderSpeed;
    public float AirSpeedCheck;
    float PlayerYAxis;

    public bool BoomerangCheck;

    public bool JetpackCollected;
    public static bool PowerUp;
    public float JetpackFuel;

    public static bool JPCollectedSlider;
    public static float JetpackFuelSlider;
    public static bool BoomerangFire;
    public static bool BoomerangMoving;

    public Animator PlayerAnimation;



    Vector2 CurrentPos;

    // Start is called before the first frame update




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastCheck();
        BoomerangCheck = BoomerangFire;
        


        if (RayCastFire.collider == null)
        {
            Grounded = false;
            
            PlayerAnimation.SetBool("Grounded", false);
           
            if (Controller.velocity.y < AirSpeedCheck)
            {
               PlayerAnimation.SetBool("IsFlying", false);
            }

            if(Pit_Script.PlayerFell == true)
            {
                transform.position = Pit_Script.PlayerRespawn;
                Pit_Script.PlayerFell = false;
            }


        }

        if (RayCastFire.collider != null)
        {
            Grounded = true;
            PlayerAnimation.SetBool("Grounded", true);
           PlayerAnimation.SetBool("IsFlying", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if (BoomerangFire == false)
            {
                BoomerangFire = true;
                BoomerangMoving = true;
                PlayerAnimation.SetBool("BoomerangThrow", true);
            }
        }




        //ref 1
        if (Input.GetKey(KeyCode.Space))
        {
            BoostedJump();
        }



        if (Input.GetKey(KeyCode.W))
        {
            LadderMovementUp();
        }

        if (Input.GetKey(KeyCode.S))
        {
            LadderMovementDown();
        }

        
        if(JetpackFuel <= 0)
        {
            JetpackDepleted = true;
        }

        if (JetpackFuel > 1)
        {
            JetpackDepleted = false;
        }


        if (Grounded == true)
        {
            if (JetpackFuel < FuelMax)
            {
                JetpackFuel += 1;
            }
        }




       JPCollectedSlider = JetpackCollected;
        JetpackFuelSlider = JetpackFuel;
        PlayerDirection = PlayerSprite;

        if(Ladder_Script.NearLadder == false)
        {
            PlayerAnimation.SetBool("IsClimbing", false);
        }

        
        JetpackCollected = PowerUp;


        PlayerYAxis = Controller.velocity.y;
        PlayerAnimation.SetFloat("AirSpeed", PlayerYAxis);

   }

    void FixedUpdate()
    {

        Movement();

    }

    void Movement()
    {
        SidewaysMovement = Input.GetAxisRaw("Horizontal") * MovementSpeed;
        Controller.AddForce(new Vector2(SidewaysMovement, 0), ForceMode2D.Force);
        PlayerAnimation.SetFloat("MSpeed", Mathf.Abs(SidewaysMovement));

        if (SidewaysMovement > 0)
        {
            PlayerSprite.flipX = false;
        }
        if (SidewaysMovement < 0)
        {
            PlayerSprite.flipX = true;
        }



    }

    void LadderMovementUp()
    {
        if (Ladder_Script.NearLadder == true)
        {
           PlayerAnimation.SetBool("IsClimbing", true);
           
            CurrentPos = transform.position;
            CurrentPos.y = transform.position.y + LadderSpeed;
            transform.position = CurrentPos;
           
           
        }
    }

    void LadderMovementDown()
    {
        if (Ladder_Script.NearLadder == true)
        {
            PlayerAnimation.SetBool("IsClimbing", true);
            CurrentPos = transform.position;
            CurrentPos.y = transform.position.y - LadderSpeed;
            transform.position = CurrentPos;
        }


    }





    void RaycastCheck()
    {
        RayCastFire = Physics2D.Raycast(transform.position, Vector2.down, RayCastSize, RayCastLayer);


    }



    void Jump ()
    {

        if (Grounded == true)
        {
            Controller.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);

        }

    }



    void BoostedJump ()
    {

        if (Grounded == false && JetpackDepleted == false)
        {
            if (JetpackCollected == true)
            {
                JetpackFuel = JetpackFuel - 1;
                Controller.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Force);
                PlayerAnimation.SetBool("IsFlying", true);
            }

            
        }

    }


}
