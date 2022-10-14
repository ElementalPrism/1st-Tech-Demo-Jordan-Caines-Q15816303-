using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Movement : MonoBehaviour
{

    public Transform PlayerY;
    Vector3 NewPos;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        NewPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        NewPos.y = PlayerY.position.y;
        transform.position = Vector3.MoveTowards(transform.position, NewPos, Speed * Time.deltaTime);


    }
}
