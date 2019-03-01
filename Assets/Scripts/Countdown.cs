using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text t_contador;
    public float initialCounter;
    public float time;
    public bool movement;
    
	private CountDownEngine engine = new CountDownEngine();

    public void Start()
    {
	    engine.Counter = initialCounter;
        movement = false;
    }

    public void Update()
    {
        t_contador.text = initialCounter.ToString("f0");

        if (engine.ShouldActivateMovement(Time.deltaTime))
        {
	        movement = true;
	        t_contador.text = "";
        }
    }
}