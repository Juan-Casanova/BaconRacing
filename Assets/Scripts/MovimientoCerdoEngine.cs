using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCerdoEngine : MonoBehaviour
{

    public float velocity;
    public float speed;
    public float time;
    public float angulo;
    public float  jump;
    public float horizontal;
    public float vertical;
    public float keyJump;
    public int maxJumps;




    public float getVelocityV()
    {
        return velocity = vertical * speed * time;
    }


    public float getVelocityH()
    {
        return velocity = horizontal*speed  * time;
    }

    public float getRotate()
    {
        return horizontal * angulo;
    }


}


