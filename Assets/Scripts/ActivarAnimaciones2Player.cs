using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAnimaciones2Player : MonoBehaviour
{
   
    public Rigidbody Cerdito;
    public Animator animacioncerdito; //hola animator del cerdito


    /// <summary>
    /// cerdito=0 significa animacion de idle
    /// cerdito=1 significa animacion de correr
    /// cerdito=2 significa animacion de frenado //no aplica al no haber aceleracion
    /// cerdito=3 significa animacion de saltoUP
    /// cerdito=4 significa animacion de daño
    /// cerdito=5 significa animacion de saltoDown
    /// cerdito=6 significa animacion de Item
    /// </summary>




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //objeto
        {

            animacioncerdito.SetInteger("cerdito", 0);
        }
        else if (Input.GetKey(KeyCode.W) || (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.D)))))
        {

            animacioncerdito.SetInteger("cerdito", 1);

        }
        else { { animacioncerdito.SetInteger("cerdito", 0); print("no presionando"); } }

        if (Input.GetKeyDown(KeyCode.N)) //daño
        {

            animacioncerdito.SetInteger("cerdito", 4);
        }
        if (Input.GetKeyDown(KeyCode.Q))//salto
        {
            animacioncerdito.SetInteger("cerdito", 3);

        }



    }

}
