using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEngine:ICheck
{
    /// <summary>
    /// Es el numero de checkpoint que tiene en cada momento
    /// </summary>
    public int currentCheckpoint;
    /// <summary>
    /// Es la cantidad de spawns que se tiene y con esta verifica cada checkpoint para
    /// saber si ya dio una vuelta
    /// </summary>
    ///<deprecated>Nel</deprecated>
    public int lenghtSpawn;
    /// <summary>
    /// Es el numero de lap 
    /// </summary>
    public int currentLap;


    public void CheckCurrentCheckpoint()
    {
   
            if (currentCheckpoint + 1 < lenghtSpawn)
            {
                currentCheckpoint++;
            }
            else
            {
                currentLap++;
                currentCheckpoint = 0;
            }
        
    }
    
    
    

}
