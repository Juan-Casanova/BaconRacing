using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCerdo : MonoBehaviour
{
    public enum numPlayer
    {
        p1,
        p2
    }

    public numPlayer NumPlayer;
    public Rigidbody rigidbody;

    public Countdown countdown = new Countdown();
    public MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();

    public void Start()
    {
        
        movimientoCerdoEngine.speed = 10.0f;
        movimientoCerdoEngine.angulo = 3.0f;
        movimientoCerdoEngine.jump = 8.0f;
        movimientoCerdoEngine.maxJumps = 3;

    }



    public void FixedUpdate()
    {
        if (NumPlayer == 0)
        {
          
            movimientoCerdoEngine.horizontal = Input.GetAxis("Horizontal");
            movimientoCerdoEngine.vertical = Input.GetAxis("Vertical");
            movimientoCerdoEngine.keyJump = Input.GetAxis("Jump");
        }
        else
        {
            movimientoCerdoEngine.horizontal = Input.GetAxis("Horizontal2");
            movimientoCerdoEngine.vertical = Input.GetAxis("Vertical2");
            movimientoCerdoEngine.keyJump = Input.GetAxis("Jump2");
        }
        if (countdown.movement)
        {
            movimientoCerdoEngine.time = Time.deltaTime;

            if (movimientoCerdoEngine.vertical != 0 || movimientoCerdoEngine.horizontal != 0)
            {

                transform.Translate(0, 0, movimientoCerdoEngine.getVelocityV());
                transform.Rotate(0, movimientoCerdoEngine.getRotate(), 0);

            }

            if (movimientoCerdoEngine.keyJump > 0)
            {
                if (movimientoCerdoEngine.maxJumps <= 0)
                {

                }
                else
                {
                    movimientoCerdoEngine.vertical = 0.0f;
                    rigidbody.velocity = new Vector3(0, movimientoCerdoEngine.jump, 0);
                    rigidbody.angularVelocity = Vector3.zero;
                    movimientoCerdoEngine.maxJumps--;
                }


            }
        }

    }




private void OnCollisionEnter(Collision collision)
    {
       movimientoCerdoEngine.maxJumps = 3;
    }

   
}




