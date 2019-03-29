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
             return; //If it's not the player dont continue
         //if (transform == ContadorVueltas.spawnA[ContadorVueltas.currentCheckpoint].transform) 
         //{             
         //    //Check so we dont exceed our checkpoint quantity
         //    if (ContadorVueltas.currentCheckpoint + 1 < ContadorVueltas.spawnA.Length) 
         //    {         
         //           ContadorVueltas.currentCheckpoint++;
         //           Debug.Log(ContadorVueltas.spawnA[ContadorVueltas.currentCheckpoint]);              
         //    } 
         //    else 
         //    {
         //        //If we dont have any Checkpoints left, go back to 0
         //        ContadorVueltas.currentLap++;
         //        ContadorVueltas.currentCheckpoint = 0;
         //    }
         // } 

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

