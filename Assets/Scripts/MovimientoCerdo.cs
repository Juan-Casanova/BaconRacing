using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// activaranimaciones activaranimaciones;
public enum numPlayer
{
    p1,
    p2
}
public class MovimientoCerdo : MonoBehaviour, IMovimientoCerdo, IItemControl
{
	
	public GameObject jugador;
	public GameObject item1TocinoPista;
	public GameObject item2Proyectil;
	public GameObject item3chile;
	public numPlayer NumPlayer;
    public Player player;
	public Rigidbody rigidbody;
    private AudioSource _audioMoneda;

	public Countdown countDown;
	public MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
    public MostrarItem mostrarItem;
    public ItemControlEngine itemControlEngine = new ItemControlEngine();

    public Transform BackSpawnPoint, FrontSpawnPoint;

    public int numRandom = 0;

    #region  Variables del Movimiento

    public float _BaseSpeed;

    public float BaseSpeed { get => _BaseSpeed; }

    [SerializeField, Range(0, 10)]
    private float _speed = 1;

    public float speed
    {
        get => _speed;
        set => _speed = value;
    }

    [SerializeField, Range(0, 10)]
    private float _jumpForce;

    public float jumpForce
    {
        get => _jumpForce;
        set => _jumpForce = value;
    }
    #endregion


    public void Start()
	{
	    countDown = managerHUD.instancia.GetComponent<Countdown>();
        mostrarItem = managerHUD.instancia.GetComponent<MostrarItem>();
        _BaseSpeed = _speed;
        movimientoCerdoEngine.speed = _speed;
		movimientoCerdoEngine.angulo = 3.0f;
		movimientoCerdoEngine.jump = _jumpForce;
		movimientoCerdoEngine.maxJumps = 3;
		item3chile.SetActive(false);

	}

	public void FixedUpdate()
	{
		var horizontalAxis = Input.GetAxis(player.input.horizontalAxis);
		var verticalAxis = Input.GetAxis(player.input.verticalAxis);
		var isJumping = Input.GetKeyDown(player.input.jump);

		if (countDown.movement)
		{
			movimientoCerdoEngine.Move(verticalAxis, horizontalAxis, Time.fixedDeltaTime, this);
			movimientoCerdoEngine.Jump(isJumping, this);
            if (Input.GetKeyDown(player.input.powerUp)&& numRandom!=0)
            {
	            itemControlEngine.ChargeItem(numRandom,this);
                mostrarItem.HideItem(numRandom, NumPlayer);
                numRandom = 0;
            }
        }
	}

	private void OnCollisionEnter(Collision collision) => movimientoCerdoEngine.maxJumps = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda") && numRandom==0)
        {
            
            numRandom = getItemRandom();
            mostrarItem.ShowItem(numRandom, NumPlayer);
            
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

	public void PoderItem1() => Instantiate(item1TocinoPista, BackSpawnPoint.position, BackSpawnPoint.rotation);

	//Item 2 Disparar objeto
	public void PoderItem2() => Instantiate(item2Proyectil, FrontSpawnPoint.position, FrontSpawnPoint.rotation);

	//Item 3 Aceleracion del personaje

	public void PoderItem3() => StartCoroutine(TiempoItem3());

	public void No_Hay_Nada() =>Debug.Log("No hay poder");

	public IEnumerator TiempoItem3()
	{
		item3chile.SetActive(true);
		movimientoCerdoEngine.speed *= 2;
		yield return new WaitForSeconds(5);
		movimientoCerdoEngine.speed = _BaseSpeed;
		item3chile.SetActive(false);
	}

	public int getItemRandom() => Random.Range(1, 4);
}