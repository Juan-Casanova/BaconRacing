using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class CheckLap : MonoBehaviour
{
    public ManagerLaps managerLaps;
    public bool isActivate1=false;
    public bool isActivate2 = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1")&&
            !isActivate1 )
        {
            isActivate1 = true;
            managerLaps.numCheckP1+=1;
           
        }else if (other.CompareTag("Player2")&&
                  !isActivate2)
        {
            isActivate2 = true;
            managerLaps.numCheckP2+=1;
        }
    }

  

}
