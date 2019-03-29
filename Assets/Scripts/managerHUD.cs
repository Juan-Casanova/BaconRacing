using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerHUD : MonoBehaviour
{

    public Text laps1;
    public Text laps2;
    public Text countDown;
    public GameObject miniMap;

    public Check check=new Check();
    public CountDownEngine countdownEngine = new CountDownEngine();
    public CheckEngine checkEngine=new CheckEngine();

    public void Update()
    {
      
      countDown.text = countdownEngine.initialCounter.ToString("f0");
      laps1.text = "LAP: " + check.checkEngine.currentLap.ToString()+"/2";

        if (countdownEngine.initialCounter < 1)
        {
           countDown.text = "";
           miniMap.SetActive(true);
        }

      
    }

}
