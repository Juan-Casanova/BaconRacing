using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTurnDown : MonoBehaviour
{
    public bool IsTurnDown=false;



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pista"))
        {
            
            IsTurnDown = true;
        }
      
         
        
      
    }
}
