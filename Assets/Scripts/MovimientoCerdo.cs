using System.Collections;
using UnityEngine;

public class MovimientoCerdo : MonoBehaviour, IMovimientoCerdo,IItemControl
{
    public GameObject jugador;
    public GameObject item1TocinoPista;
    public GameObject item2Proyectil;
    public GameObject item3chile;

    public MovimientoCerdo movimientoCerdo;

    // activaranimaciones activaranimaciones;
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
    public ItemControlEngine itemControlEngine=new ItemControlEngine();


    public int numRandomP1 = 0;
    public int numRandomP2 = 0;

    public void Start()
	{
		movimientoCerdoEngine.speed = 10.0f;
		movimientoCerdoEngine.angulo = 3.0f;
		movimientoCerdoEngine.jump = 8.0f;
		movimientoCerdoEngine.maxJumps = 3;
        item3chile.SetActive(false);

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
                itemControlEngine.ChargeItem(numRandomP1,this);
                mostrarItem.HideAllItems();
                numRandomP1 = 0;
            }
            if (Input.GetKey(KeyCode.E) && numRandomP2 != 0 )
            {
                itemControlEngine.ChargeItem(numRandomP2,this);
                mostrarItem.HideAllItems();
                numRandomP2 = 0;
            }
        }
	}

	private void OnCollisionEnter(Collision collision) => movimientoCerdoEngine.maxJumps = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda")&&NumPlayer == numPlayer.p1 && numRandomP1==0)
        {
            numRandomP1 = getItemRandom();
            mostrarItem.ShowItem(numRandomP1,numPlayer.p1);
        }
        else if(other.CompareTag("Moneda") && NumPlayer == numPlayer.p2 && numRandomP2 == 0)
        {
            numRandomP2 = getItemRandom();
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


    //Item1 Poder de dejar un tocino en la pista

    public void PoderItem1() => Instantiate(item1TocinoPista, new Vector3(jugador.transform.position.x, jugador.transform.position.y + .4f, jugador.transform.position.z - .4f), jugador.transform.rotation);

    //Item 2 Disparar objeto
    public void PoderItem2() => Instantiate(item2Proyectil, new Vector3(jugador.transform.position.x, jugador.transform.position.y + 1.2f, jugador.transform.position.z + 3), transform.rotation);

    //Item 3 Aceleracion del personaje

    public void PoderItem3() => StartCoroutine(TiempoItem3());

     public IEnumerator TiempoItem3()
     {
        item3chile.SetActive(true);
        movimientoCerdo.movimientoCerdoEngine.speed = 15;
        yield return new WaitForSeconds(5);
        movimientoCerdo.movimientoCerdoEngine.speed = 10;
        item3chile.SetActive(false);
     }

    public int getItemRandom() => Random.Range(1, 3);

}