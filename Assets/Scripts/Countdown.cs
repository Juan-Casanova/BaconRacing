using UnityEngine;

public class Countdown : MonoBehaviour
{

    public CountDownEngine countDownEngine = new CountDownEngine();

	/// <summary>
	/// Indica si el personaje se puede mover.
	/// </summary>
    public bool movement;



    public void Start()
    {
        countDownEngine.time = Time.deltaTime;
        countDownEngine.initialCounter = 5.0f;
        movement = false;
    }

    public void Update()
    {
        countDownEngine.countdownToActivateMovement();
        if (countDownEngine.initialCounter < 1)
        {
            countDownEngine.initialCounter = 0;
            movement = true;
        }
    }
}