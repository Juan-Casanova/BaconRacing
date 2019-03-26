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

    public CountDownEngine countDownEngine = new CountDownEngine();

 

    public void Update()
    {
      countDown.text = countDownEngine.initialCounter.ToString("f0");
        
        if (countDownEngine.initialCounter < 1)
        {
           countDown.text = "";
           miniMap.SetActive(true);
        }

      
    }

}
