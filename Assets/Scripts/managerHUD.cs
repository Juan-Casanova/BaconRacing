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
    public CountDownEngine countDownEngine = new CountDownEngine();
    private int numRandom;
 

    public void Update()
    {
      countDown.text = countDownEngine.initialCounter.ToString("f0");
      //mostrarItem.ShowItem(numRandom);
        if (countDownEngine.initialCounter < 1)
        {
           countDown.text = "";
           miniMap.SetActive(true);
        }

      
    }

}
