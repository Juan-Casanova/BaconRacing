using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownEngine : MonoBehaviour
{
    public float initialCounter;
    public float time;

    public bool countdownToActivateMovement()
    {
        initialCounter -= time;

        return initialCounter <= 0;
    }
}
