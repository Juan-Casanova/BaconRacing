 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class ContadorVueltas : MonoBehaviour 
 {    
     // These Static Variables are accessed in "checkpoint" Script
     public Transform[] spawnArray;
     public static Transform[] spawnA;
     public static int currentCheckpoint = 0; 
     public static int currentLap = 0; 
     public Vector3 startPos;
     public int Lap;
     
     void  Start ()
     {
         startPos = transform.position;
         currentCheckpoint = 0;
         currentLap = 0;  
     } 
     void  Update ()
     {
         Lap = currentLap;
         spawnA = spawnArray;         
     }     
 }