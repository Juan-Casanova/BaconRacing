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
    public Transform player1, player2,meta;

    public Image[] instructions;
    public Image[] winner;

    public Check check=new Check();
    public CheckEngine checkEngine=new CheckEngine();
    public Countdown _countdown=new Countdown();
    public CountDownEngine countdownEngine = new CountDownEngine();

    private void Start()=>HideScreens();
 

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
            laps1.text = check.checkEngine.currentLap.ToString()+"/2";
            laps2.text = check.checkEngine.currentLap.ToString() + "/2";

            if (check.checkEngine.currentLap > 2)
                StartCoroutine(changeNextTrack("PistaBosqueChina", distanceP1, distanceP2));
        
    }

    private IEnumerator changeNextTrack(string nextTrack,float distanceP1,float distanceP2)
    {
        if (distanceP1 >= distanceP2)
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
            winner[i].enabled = false;


    }

}
