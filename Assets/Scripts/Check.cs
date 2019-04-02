using UnityEngine;
 using System.Collections;
 
 public class Check : MonoBehaviour,ICheck
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
         if (other.CompareTag("Player")) 
         CheckCurrentCheckpoint();
     }


     public void CheckCurrentCheckpoint()
     {
         if (transform == ContadorVueltas.spawnA[ContadorVueltas.currentCheckpoint].transform)
         {
             if (checkEngine.currentCheckpoint + 1 < checkEngine.lenghtSpawn)
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

}

