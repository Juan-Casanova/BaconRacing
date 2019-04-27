using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class managerHUD : MonoBehaviour
{

    public static managerHUD instancia;

    public Text laps1;
    public Text laps2;

    public Text posPlayer1;
    public Text posPlayer2;
    public Text countDown;
    public Transform player1, player2,meta;

    public Image[] instructions;
    
    public Check check=new Check();
    public CheckEngine checkEngine=new CheckEngine();
    public Countdown _countdown=new Countdown();
    public CountDownEngine countdownEngine = new CountDownEngine();

    [Header("Game Over Settings")]
    public Text player1gameOver;
    public Text player2gameOver;
    
    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(this);
        }
    
    }

    public void Start()
    {
        Spawner.PlayersSpawnEvent += Settup;
        ContadorVueltas.LapCompletedEvent += ActualizarLapHUD;
    }
    public void OnDestroy()
    {
        Spawner.PlayersSpawnEvent -= Settup;
        ContadorVueltas.LapCompletedEvent -= ActualizarLapHUD;

    }
    public void Settup()
    {
        player1 = GameManager.instancia.player1Instancia.transform;
        player2 = GameManager.instancia.player2Instancia.transform;
    }
    public void Update()
    {
        float distanceP1 = Vector3.Distance(player1.position, meta.position);
        float distanceP2 = Vector3.Distance(player2.position, meta.position);


        countDown.text = _countdown.countDownEngine.initialCounter < 1 ? countDown.text = "" : _countdown.countDownEngine.initialCounter.ToString("f0");

        if (_countdown.movement)
        {
            instructions[0].enabled = false;
            instructions[1].enabled = false;
        }
        posPlayer1.text = distanceP1 >= distanceP2 ? "2":"1";
        posPlayer2.text = distanceP2 >= distanceP1 ? "2":"1";
        
    }
    public void ActualizarLapHUD(ContadorVueltas contador)
    {
        MovimientoCerdo cerdito = contador.GetComponent<MovimientoCerdo>();
        switch(cerdito.NumPlayer)
        {
            case numPlayer.p1:
                laps1.text = contador.currentLap+"/2";
            break;
            case numPlayer.p2:
                laps2.text = contador.currentLap+"/2";
            break;
        }        
    }
    public void ShowGameResults(numPlayer player)   
    {
        player1gameOver.transform.parent.gameObject.SetActive(true);
        player2gameOver.transform.parent.gameObject.SetActive(true);

        switch(player)
        {
            case numPlayer.p1:
                player1gameOver.text = "You Win";
                player2gameOver.text = "You Lose";
            break;
            case numPlayer.p2:
                player1gameOver.text = "You Lose";
                player2gameOver.text = "You Win";
            break;
        }
    }

    

}
