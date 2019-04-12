using UnityEngine;
 using System.Collections;
 
 public class Check : MonoBehaviour
 {

     public CheckEngine checkEngine = new CheckEngine();


    public void Start()
    {
        checkEngine.currentCheckpoint = ContadorVueltas.currentCheckpoint;
        checkEngine.currentLap = ContadorVueltas.currentLap;
        checkEngine.lenghtSpawn = ContadorVueltas.spawnA.Length;
    }

    void  OnTriggerEnter ( Collider other )
     {
        //if (other.CompareTag("Player1")|| other.CompareTag("Player2")) 
        //CheckCurrentCheckpoint();
        if (checkEngine.currentCheckpoint < checkEngine.lenghtSpawn)
        {
            checkEngine.currentCheckpoint++;
        }
        else
        {
            checkEngine.currentLap++;
            checkEngine.currentCheckpoint = 0;
        }

    }



 }

