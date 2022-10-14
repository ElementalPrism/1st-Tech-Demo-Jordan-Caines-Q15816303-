using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    //ref 2
    public Slider JetpackSlide;

    // Start is called before the first frame update
    void Start()
    {
        JetpackSlide.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        
        if (Player_Script.JPCollectedSlider == false)
        {
            JetpackSlide.enabled = false;
        }

        if (Player_Script.JPCollectedSlider == true)
        {
            JetpackSlide.enabled = true;
        }
        
        //ref 2
        JetpackSlide.value = Player_Script.JetpackFuelSlider;



    }
}
