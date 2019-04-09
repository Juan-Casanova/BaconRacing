using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activaranimaciones : MonoBehaviour
{

  
    public int numRandom;
    public Rigidbody Cerdito;
       public Animator animacioncerdito; //hola animator del cerdito
    public Animator anicharacter; //animator del personaje
    int randomidle;//variable para generar un random para que sea diferente el idle 

   

    void Start()
    {

        animacioncerdito.SetInteger("cerdito", 0);// numaniCerdito=numAniCerdito.idle);
        anicharacter.SetInteger("personaje", 0);
        Debug.Log(randomidle);
        randomidle = Random.Range(1, 13);
    }

    IEnumerator corutinawaitfrenadoyluegocorrer()//para el cerdito
    {
        animacioncerdito.SetInteger("cerdito", 2);
        yield return new WaitForSeconds(3f);
        animacioncerdito.SetInteger("cerdito", 1);
    }


    // Update is called once per frame
    void Update()
    {

      while (Input.GetKeyDown(KeyCode.UpArrow)|| (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            print("presionando");
            animacioncerdito.SetInteger("cerdito", 1);
            //StartCoroutine(corutinawaitfrenadoyluegocorrer());
            //anicharacter.SetInteger("personaje", 1);

        }  { animacioncerdito.SetInteger("cerdito", 0); print("no presionando");       }
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("saltando");
        }













    }
   
}



