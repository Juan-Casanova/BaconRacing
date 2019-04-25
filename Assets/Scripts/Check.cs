using UnityEngine;
 using System.Collections;
 
 public class Check : MonoBehaviour
 {
    public int index;

    public CheckEngine checkEngine;
   

    public void Start()
    {
        checkEngine = new CheckEngine();
        //checkEngine.lenghtSpawn = ContadorVueltas.spawnA.Length;
    }

    void  OnTriggerEnter ( Collider other )
     {
        //if (other.CompareTag("Player1")|| other.CompareTag("Player2")) 
        //CheckCurrentCheckpoint();
        if (other.CompareTag("Player"))
        {
            ContadorVueltas contador = other.GetComponent<ContadorVueltas>();

            if(contador.currentCheckpoint == index-1)
            {
                contador.currentCheckpoint = index;
            }
        }
    }
 }

