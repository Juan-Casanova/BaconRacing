using UnityEngine;


public class Countdown : MonoBehaviour
{
	public CountDownEngine countDownEngine;
     public bool movement;

    public void Start()
    {

        countDownEngine.initialCounter = 5.0f;
        movement = false;
    }

    public void Update()
    {
        countDownEngine.time = Time.deltaTime;
        movement=countDownEngine.countdownToActivateMovement();
        Debug.Log(countDownEngine.initialCounter);
    }

}