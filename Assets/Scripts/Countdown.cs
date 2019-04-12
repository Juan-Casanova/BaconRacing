using UnityEngine;

public class Countdown : MonoBehaviour
{
<<<<<<< HEAD

     public CountDownEngine countDownEngine = new CountDownEngine();
=======
	 public CountDownEngine countDownEngine=new CountDownEngine();
>>>>>>> Feature/IntegracionCodigoSonidoYEfecto
     public bool movement;

    public void Start()
    {
<<<<<<< HEAD
        countDownEngine.time = Time.deltaTime;
=======
>>>>>>> Feature/IntegracionCodigoSonidoYEfecto
        countDownEngine.initialCounter = 5.0f;
        movement = false;

    }

    public void Update()
    {
<<<<<<< HEAD
        countDownEngine.countdownToActivateMovement();
        if (countDownEngine.countdownToActivateMovement())
        {
            countDownEngine.initialCounter = 0;
            movement = true;
        }
=======
       
        countDownEngine.time = Time.deltaTime;
        movement=countDownEngine.countdownToActivateMovement();

>>>>>>> Feature/IntegracionCodigoSonidoYEfecto
    }
}