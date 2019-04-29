using UnityEngine;
 using System.Collections;
 
 public class Check : MonoBehaviour
 {
    public int index;

    public CheckEngine checkEngine;

    

    public MovimientoCerdo MovimientoCerdo;


    public void Start() => checkEngine = new CheckEngine();
        //checkEngine.lenghtSpawn = ContadorVueltas.spawnA.Length;

        void OnTriggerEnter(Collider other)
        {
            //if (other.CompareTag("Player1")|| other.CompareTag("Player2")) 
            //CheckCurrentCheckpoint();
            if (other.CompareTag("Player"))
            {
                //Debug.Log(transform.position);
                //MovimientoCerdo.PosRes =transform.position;
                ContadorVueltas contador = other.GetComponent<ContadorVueltas>();
                

                if (contador.currentCheckpoint == index - 1)
                {
                    contador.currentCheckpoint = index;
                }
            }

            if (other.gameObject.name=="cerditoP1(Clone)")
            {
                MovimientoCerdo.PosRes1 = transform.position;
                MovimientoCerdo.cerditoRespawn1();
            }
            if (other.gameObject.name == "cerditoP2(Clone)")
            {
                MovimientoCerdo.PosRes2 = transform.position;
                MovimientoCerdo.cerditoRespawn2();
            }
    }

 }

