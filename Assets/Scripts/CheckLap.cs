using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class CheckLap : MonoBehaviour
{
    public ManagerLaps managerLaps;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1")&&
            !managerLaps.isActivate[managerLaps.numCheckP1] )
        {
            managerLaps.isActivate[managerLaps.numCheckP1] = true;
            managerLaps.numCheckP1+=1;
           
        }else if (other.CompareTag("Player2")&&
                  !managerLaps.isActivate[managerLaps.numCheckP2+=4])
        {
            managerLaps.isActivate[managerLaps.numCheckP2] = true;
            managerLaps.numCheckP2+=1;
        }
    }

  

}
