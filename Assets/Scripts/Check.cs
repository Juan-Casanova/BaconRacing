using UnityEngine;
 using System.Collections;
 
 public class Check : MonoBehaviour {     
     void  OnTriggerEnter ( Collider other  )
     {
         //Is it the Player who enters the collider?
         if (other.CompareTag("Player")) 
             return; //If it's not the player dont continue
         if (transform == ContadorVueltas.spawnA[ContadorVueltas.currentCheckpoint].transform) 
         {             
             //Check so we dont exceed our checkpoint quantity
             if (ContadorVueltas.currentCheckpoint + 1 < ContadorVueltas.spawnA.Length) 
             {         
                    ContadorVueltas.currentCheckpoint++;
                    Debug.Log(ContadorVueltas.spawnA[ContadorVueltas.currentCheckpoint]);              
             } 
             else 
             {
                 //If we dont have any Checkpoints left, go back to 0
                 ContadorVueltas.currentLap++;
                 ContadorVueltas.currentCheckpoint = 0;
             }
          } 
     }
 
 }

