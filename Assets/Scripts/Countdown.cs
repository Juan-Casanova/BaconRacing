using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public CountDownEngine countDownEngine = new CountDownEngine();
    public bool movement;



    public void Start()
    {
        countDownEngine.time = Time.deltaTime;
        countDownEngine.initialCounter = 3.0f;
        movement = false;
    }

    public void Update()
    {
        countDownEngine.countdownToActivateMovement();
        if (countDownEngine.initialCounter < 1)
        {
            movement = true;
        }
    }
}