using UnityEngine;

public class MovimientoCerdo : MonoBehaviour, IMovimientoCerdo
{
	public enum numPlayer
	{
		p1,
		p2
	}

    private int numItemToActivate=0;
	public numPlayer NumPlayer;
	public Rigidbody rigidbody;

	public Countdown countDown=new Countdown();
	public MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
    public MostrarItem mostrarItem=new MostrarItem();
    public ItemControl itemControl=new ItemControl();

	public void Start()
	{
		movimientoCerdoEngine.speed = 10.0f;
		movimientoCerdoEngine.angulo = 3.0f;
		movimientoCerdoEngine.jump = 8.0f;
		movimientoCerdoEngine.maxJumps = 3;
	}

	public void FixedUpdate()
	{
		string playerSuffix = NumPlayer == 0 ? "" : "2";
		var horizontalAxis = Input.GetAxis($"Horizontal{playerSuffix}");
		var verticalAxis = Input.GetAxis($"Vertical{playerSuffix}");
		var isJumping = Input.GetAxis($"Jump{playerSuffix}") > 0;
        var activateItem = Input.GetAxis($"Fire{playerSuffix}");

		if (countDown.movement)
		{
			movimientoCerdoEngine.Move(verticalAxis, horizontalAxis, Time.fixedDeltaTime, this);
			movimientoCerdoEngine.Jump(isJumping, this);

            if (activateItem > 0 && numItemToActivate != 0)
            {
                itemControl.ChargeItem(numItemToActivate);
                mostrarItem.HideAllIconosItems();
                numItemToActivate = 0;
            }
        }
	}

	private void OnCollisionEnter(Collision collision)=> movimientoCerdoEngine.maxJumps = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            numItemToActivate = itemControl.GetItemRandom();
            mostrarItem.ShowItem(numItemToActivate);
        }
    }

	public void Move(float verticalVelocity, float rotation)
	{
		transform.Translate(0, 0, verticalVelocity);
		transform.Rotate(0, rotation, 0);
	}

	public void Jump(float jumpForce)
	{
		rigidbody.velocity = new Vector3(0, jumpForce, 0);
		rigidbody.angularVelocity = Vector3.zero;
	}
}