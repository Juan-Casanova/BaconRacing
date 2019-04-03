using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        else
        {

            posPlayer1.text = distanceP1 >= distanceP2 ? "POS: " + "1" + "/2" : "POS: " + "2" + "/2";
            posPlayer2.text = distanceP2 >= distanceP1 ? "POS: " + "1" + "/2" : "POS: " + "2" + "/2";
            laps1.text = "LAP: " + check.checkEngine.currentLap.ToString() + "/2";
        }
  
        
       

     
    }

}
