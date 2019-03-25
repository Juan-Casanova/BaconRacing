using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCerdo : MonoBehaviour
{
    public GameObject player1;


   // public GameObject player2;

    MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();

   
    //public float velocity;
    //public float maxSpeed;
    // public float speed;
    // public float time;
    // public float angulo;
    // public float jump;
    // public int maxJumps;


    public void Start()
    {
   
        movimientoCerdoEngine.speed = 10.0f;
       // movimientoCerdoEngine.time = Time.deltaTime;
        movimientoCerdoEngine.angulo = 3.0f;
        movimientoCerdoEngine.jump = 8.0f;
        movimientoCerdoEngine.maxJumps = 3;
        //movimientoCerdoEngine.vertical = Input.GetAxis("Vertical");
        //movimientoCerdoEngine.horizontal = Input.GetAxis("Horizontal");
        //movimientoCerdoEngine.jump = Input.GetAxis("Jump");

    }
    //{
    //    speed = 10.0f;
    //    time = Time.deltaTime;
    //    angulo = 3.0f;
    //    jump = 8.0f;

    //    maxJumps=3;

    

    public void FixedUpdate()
    {
        movimientoCerdoEngine.time = Time.deltaTime;
        movimientoCerdoEngine.vertical = Input.GetAxis("Vertical");
        movimientoCerdoEngine.horizontal = Input.GetAxis("Horizontal");
        movimientoCerdoEngine.jump = Input.GetAxis("Jump");
        // transformsMovimiento();
        //   transformJump();
        movimientoCerdoEngine.movimientoCerdito();

        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //float keyJump = Input.GetAxis("Jump");

        //velocity = vertical * speed * time;

        //if (vertical != 0 || horizontal != 0 )
        //{

        //transform.Translate(0, 0, velocity);
        //transform.Translate(horizontal * speed * time, 0, 0);

        //transform.Rotate(0, horizontal * angulo, 0);
        //    if (keyJump != 0)
        //    {
        //        horizontal = 0.0f;
        //        vertical = 0.0f;
        //        if (maxJumps <= 0)
        //        {

        //        }
        //        else
        //        {
        //rigiBodyJump.velocity = new Vector3(0, jump, 0);
        //rigiBodyJump.angularVelocity = Vector3.zero;
        //maxJumps--;
        //        }
        //    }


        //}


    }


    private void OnCollisionEnter(Collision collision)
    {
       movimientoCerdoEngine.maxJumps = 3;
    }

    //public void transformsMovimiento()
    //{
       
    //}

    //public void transformJump()
    //{
      
    //}

    //public void movimientoCerdito()
    //{

      
    //}



}




