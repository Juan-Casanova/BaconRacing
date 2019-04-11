using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class managerHUD : MonoBehaviour,IManagerHUD
{

    public Text laps1;
    public Text laps2;

    public Text posPlayer1;
    public Text posPlayer2;
    public Text countDown;
    public Transform player1, player2;

    public Image[] instructions;
    public Image[] winner;
    public GameObject meta;

    public Countdown countdown;
    public CountDownEngine countDownEngine=new CountDownEngine();
    public ManagerLap chekCheckLapEngine=new ManagerLap();
    public ManagerHUDEngine managerHudEngine=new ManagerHUDEngine();


    private void Start() => managerHudEngine.HideScreens(this);
   

    public void Update()
    {
        #region Asignacion d evaribales del Engine
        managerHudEngine.isMovementActive = countdown.movement;
        managerHudEngine.isInstructionsP1Active = instructions[0].enabled = false;
        managerHudEngine.isInstructionsP2Active = instructions[1].enabled = false;
        managerHudEngine.t_posPlayer1 = posPlayer1.text;
        managerHudEngine.t_posPlayer2 = posPlayer2.text;
        managerHudEngine.t_laps1 = laps1.text;
        managerHudEngine.t_laps2 = laps2.text;
        managerHudEngine.distanceP1 = Vector3.Distance(player1.position, meta.transform.position);
        managerHudEngine.distanceP2 = Vector3.Distance(player2.position, meta.transform.position);
        managerHudEngine.t_coutndown = countDown.text;
        managerHudEngine.initialCounter = countDownEngine.initialCounter;
#endregion
        managerHudEngine.ActivateHUD();
       
        if (chekCheckLapEngine.lapPlayer1 > 2 || chekCheckLapEngine.lapPlayer2 > 2)
        {
            StartCoroutine(changeNextTrack("PistaBosqueChina", managerHudEngine.distanceP1,managerHudEngine.distanceP2));
        }

    }

    private IEnumerator changeNextTrack(string nextTrack,float distanceP1,float distanceP2)
    {
        checkWinner();

        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(nextTrack,LoadSceneMode.Single);
    }

    public void HideScreens()
    {
        for (int i = 0; i < winner.Length; i++)
        {
            winner[i].enabled = false;

        }
    }


    public void checkWinner()
    {
        if (chekCheckLapEngine.lapPlayer1 >= chekCheckLapEngine.lapPlayer1)
        {
            winner[0].enabled = true;
            winner[2].enabled = true;
        }
        else
        {
            winner[1].enabled = true;
            winner[3].enabled = true;
        }
    }

 

}
