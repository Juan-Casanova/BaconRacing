using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class managerHUD : MonoBehaviour
{

    public Text laps1;
    public Text laps2;

    public Text posPlayer1;
    public Text posPlayer2;
    public Text countDown;
    public Transform player1, player2;

    public Image[] instructions;
    public Image[] winner;

    public Countdown countdown;
    public CountDownEngine countDownEngine;
    public CheckLap check=new CheckLap();



    private void Start()
    {
        HideScreens();
    }

    public void Update()
    {
        float distanceP1 = Vector3.Distance(player1.position, player2.position);
        float distanceP2 = Vector3.Distance(player2.position, player1.position);


        countDown.text = countDownEngine.initialCounter < 1 ? countDown.text = "" : countDownEngine.initialCounter.ToString("f0");

        if (countdown.movement)
        {
            instructions[0].enabled = false;
            instructions[1].enabled = false;
        }
            posPlayer1.text = distanceP1 >= distanceP2 ? "POS: " + "1" + "/2" : "POS: " + "2" + "/2";
            posPlayer2.text = distanceP2 >= distanceP1 ? "POS: " + "1" + "/2" : "POS: " + "2" + "/2";
            laps1.text = "LAP: " +check.lapP1+ "/2";
            laps2.text = "LAP: "+check.lapP2 + "/2";

        if (check.lapP1 > 2 || check.lapP2 > 2)
        {
            StartCoroutine(changeNextTrack("PistaBosqueChina", distanceP1, distanceP2));
        }

    }

    private IEnumerator changeNextTrack(string nextTrack,float distanceP1,float distanceP2)
    {
        if (check.lapP1 >= check.lapP2)
        {
            winner[0].enabled = true;
            winner[2].enabled = true;
        }
        else
        {
            winner[1].enabled = true;
            winner[3].enabled = true;
        }
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(nextTrack,LoadSceneMode.Single);
    }

    private void HideScreens()
    {
        for (int i = 0; i < winner.Length; i++)
        {
            winner[i].enabled = false;

        }
    }

 

}
