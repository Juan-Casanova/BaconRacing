using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCerdoEngine : MonoBehaviour, IMovimientoCerdo
{

    public float velocity;
    public float minSpeed;
    public float maxSpeed;
    public float speed;
    public float time;
    public float angulo;
    public float jump;
    public float horizontal;
    public float vertical;
    public float keyJump;
    public int maxJumps;
    public Rigidbody rigidbodyJump;



    public void movimientoCerdito()
    {
        

        if (vertical != 0 || horizontal != 0)
        {
           transformsMovimiento();
            if (keyJump != 0)
            {
                horizontal = 0.0f;
                vertical = 0.0f;
                if (maxJumps <= 0)
                {

                }
                else
                {
                  transformJump();
                }
            }
        }

        
    }

    public float getVelocityV()
    {
        return velocity = vertical * speed * time;
    }

    public float getVelocityH()
    {
        return velocity = horizontal * speed * time;
    }

    public float getRotate()
    {
        return horizontal * angulo;
    }

    public void transformsMovimiento()
    {
        Debug.Log("InterfaceMethod1");
        transform.Translate(0, 0, getVelocityV());
        transform.Translate(getVelocityH(), 0, 0);
        transform.Rotate(0, getRotate(), 0);
    }

    public void transformJump()
    {
        Debug.Log("InterfaceMethod2");
        rigidbodyJump.velocity = new Vector3(0, jump, 0);
        rigidbodyJump.angularVelocity = Vector3.zero;
        maxJumps--;

    }



}


