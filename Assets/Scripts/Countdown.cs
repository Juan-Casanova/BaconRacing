using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
   
    public float initialCounter;
    public float time;
    public bool movement;
    

    public void Start()
    {
        movement = false;
    }

    public void Update()
    {

        initialCounter -= Time.deltaTime;
        if (initialCounter < 1)
        {
            movement = true;
            initialCounter = 0;
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