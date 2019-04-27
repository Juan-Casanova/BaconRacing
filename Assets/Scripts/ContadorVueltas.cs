 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class ContadorVueltas : MonoBehaviour 
 {    
     // These Static Variables are accessed in "checkpoint" Script
     public Transform[] spawnArray;
     public static Transform[] spawnA;
     public int currentCheckpoint = 0;
     
     public delegate void OnLapCompleted(ContadorVueltas contador);
     public static event OnLapCompleted LapCompletedEvent;
      
     private int _currentLap = 0;
     public int currentLap
     {
        get
        {
            return _currentLap;  
        }
        set
        {
            if(LapCompletedEvent != null) LapCompletedEvent(this);
            
            _currentLap++;
        }
     }
     public Vector3 startPos;
     public int Lap;
     
     
     void  Start ()
     {
         startPos = transform.position;
         currentCheckpoint = 0;
         currentLap = 0;  
     }  
 }