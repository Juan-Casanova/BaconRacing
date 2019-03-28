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

   // public MostrarItem mostrarItem = new MostrarItem();
    public CountDownEngine countdownEngine = new CountDownEngine();
    public CheckEngine checkEngine=new CheckEngine();

    public void Update()
    {
      countDown.text = countdownEngine.initialCounter.ToString("f0");
      laps1.text = "LAP: "+checkEngine.currentLap.ToString()+"/2";
      //mostrarItem.ShowItem(numRandom);
        if (countdownEngine.initialCounter < 1)
        {
           countDown.text = "";
           miniMap.SetActive(true);
        }

      
    }

}
