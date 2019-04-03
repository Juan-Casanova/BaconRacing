using UnityEngine;

public class MovimientoCerdo : MonoBehaviour, IMovimientoCerdo
{
	public enum numPlayer
	{
		p1,
		p2
	}

	public numPlayer NumPlayer;
	public Rigidbody rigidbody;

	public Countdown countDown=new Countdown();
	public MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
    public MostrarItem mostrarItem=new MostrarItem();
    public ItemControl itemControl=new ItemControl();


    public int numRandomP1 = 0;
    public int numRandomP2 = 0;

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

		if (countDown.movement)
		{
			movimientoCerdoEngine.Move(verticalAxis, horizontalAxis, Time.fixedDeltaTime, this);
			movimientoCerdoEngine.Jump(isJumping, this);
            if (Input.GetKey(KeyCode.M)&& numRandomP1!=0)
            {
                itemControl.ChargeItem(numRandomP1);
                mostrarItem.HideAllIcons();
                numRandomP1 = 0;
            }
            if (Input.GetKey(KeyCode.E) && numRandomP2 != 0 )
            {
                itemControl.ChargeItem(numRandomP2);
                mostrarItem.HideAllIcons();
                numRandomP2 = 0;
            }
        }
	}

	private void OnCollisionEnter(Collision collision) => movimientoCerdoEngine.maxJumps = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda")&&NumPlayer == numPlayer.p1)
        {
            numRandomP1 = itemControl.getItemRandom();
            mostrarItem.ShowItem(numRandomP1,numPlayer.p1);
        }
        else if(other.CompareTag("Moneda") && NumPlayer == numPlayer.p2)
        {
            numRandomP2 = itemControl.getItemRandom();
            mostrarItem.ShowItem(numRandomP2,numPlayer.p2);
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