using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit_Script : MonoBehaviour
{
    public static bool PlayerFell;
    public bool Fell;
    public Transform RespawnPoint;
    public static Vector2 PlayerRespawn;

    // Start is called before the first frame update
    void Start()
    {
        PlayerFell = false;
    }

    // Update is called once per frame
    void Update()
    {
        Fell = PlayerFell;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerRespawn = RespawnPoint.position; 
        PlayerFell = true;
        
    }



}
