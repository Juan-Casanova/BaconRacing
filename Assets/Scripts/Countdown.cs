using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text t_contador;
    public float initialCounter;
    public float time;
    public bool movement;
    

    public void Start()
    {
        movement = false;
    }

    public void Update()
    {
        t_contador.text = initialCounter.ToString("f0");
        initialCounter -= Time.deltaTime;
        if (initialCounter < 1)
        {
            movement = true;
            initialCounter = 0;
            t_contador.text = "";

        }
        activateMovement(initialCounter,time,movement);

    }


    public bool activateMovement(float initialCounter,float time,bool activateMovement)
    {
        time-=Time.deltaTime;
        
        initialCounter -= time;
        if (initialCounter < 0)
        {
            activateMovement = true;
            initialCounter = 0;
        }

        return activateMovement;
    }


}