using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public float PlatformSpeed;
    public float TurnDistance;
    public Transform Pos1, Pos2;
    Vector2 NextPos;





    // Start is called before the first frame update
    void Start()
    {
        transform.position = Pos1.position;
        NextPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(transform.position, Pos1.position) < TurnDistance)
        {
            NextPos = Pos2.position;
        }

        
        if (Vector2.Distance(transform.position, Pos2.position) < TurnDistance)
        {
            NextPos = Pos1.position;
        }


        transform.position = Vector2.MoveTowards(transform.position, NextPos, PlatformSpeed * Time.deltaTime);

    }
}
