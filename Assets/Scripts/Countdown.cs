using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public CountDownEngine countDownEngine = new CountDownEngine();
    public bool movement =false;

    public void Start() => countDownEngine.initialCounter = 5.0f;

    public void Update()
    {
        countDownEngine.time = Time.deltaTime;
        movement = countDownEngine.countdownToActivateMovement();
    }
}
