using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownEngine 
{
    public bool activateMovementEngine(float initialCounter, float time)
    {
        initialCounter -= time;

        return initialCounter<=0;
    }
}
