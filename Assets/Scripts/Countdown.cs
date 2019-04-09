using UnityEngine;

public interface ICountdown
{
	void StartMovement();
}

public class Countdown : MonoBehaviour, ICountdown
{
	public CountDownEngine countDownEngine;
     public bool movement;

    public void Start()
    {
		countDownEngine = new CountDownEngine(this);
        countDownEngine.time = Time.deltaTime;
        countDownEngine.initialCounter = 5.0f;
        movement = false;
    }

    public void Update()
    {
	    countDownEngine.countdownToActivateMovement();
    }

    public void StartMovement() => movement = true;
}