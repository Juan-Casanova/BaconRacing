
using UnityEngine;


public class CheckLap : MonoBehaviour
{
    public CheckLapEngine checkLapEngine/* = new CheckLapEngine()*/;
  
    public void OnTriggerEnter(Collider other)
    {
        checkLapEngine.ManageCheckLap(other.CompareTag("Player1"));
        checkLapEngine.CheckCurrentLap();
    }


}

