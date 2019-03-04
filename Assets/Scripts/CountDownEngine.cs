using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownEngine
{
    public float initialCounter;

    public bool activateMovementEngine(float time)
    {
        initialCounter -= time;

        return initialCounter<=0;
    }
}
