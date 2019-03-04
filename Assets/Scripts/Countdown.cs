using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    CountDownEngine countDownEngine=new CountDownEngine();
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
       
        if (initialCounter < 1)
        {
            movement = true;
            initialCounter = 0;
            t_contador.text = "";

        }

        movement = countDownEngine.activateMovementEngine(Time.deltaTime);

    }


   


}