using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public int index;
    MetaEngine _MetaEngine = new MetaEngine();
    Real_Menu_manager realMenuManager=new Real_Menu_manager();

    void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player1")|| other.CompareTag("Player2")) 
        //CheckCurrentCheckpoint();

        ContadorVueltas contador = other.GetComponent<ContadorVueltas>();
        //if (contador)
        //_MetaEngine.Vueltas( other.tag, contador.currentCheckpoint, index, ref contador._currentLap, ref contador.currentCheckpoint, GameManager.instancia, other.gameObject);



        if (contador)
            if (other.CompareTag("Player") && contador.currentCheckpoint == index - 1)
            {
                contador.currentLap++;
                contador.currentCheckpoint = 0;
                if (contador.currentLap >= 3)
                {
                    realMenuManager.GuardarSaldo();
                    GameManager.instancia.GameOver(other.gameObject);
                }
                /*
                if (checkEngine.currentCheckpoint < checkEngine.lenghtSpawn)
                {
                    checkEngine.currentCheckpoint++;
                }
                else
                {
                    checkEngine.currentLap++;
                    checkEngine.currentCheckpoint = 0;
                }
                */

            }
    }
}
