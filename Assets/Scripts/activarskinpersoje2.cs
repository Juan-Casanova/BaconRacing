using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class activarskinpersoje : MonoBehaviour
{

    ///  aqui ira el codigo de la interfaz blue_selection
    public Text seleccionpersonajeinterfaz;//para acceder a el valor del personaje seleccionado
    public GameObject skincuahu, skinrev; //donde iran las diferentes skins que se activaran segun el personaje que seleccionen
   


    // Start is called before the first frame update
    void Start()
    {

       seleccionpersonajeinterfaz.text = Blue_Selection.personajeinterfaz.ToString();



    }

    // Update is called once per frame
    void Update()
    {


        switch (seleccionpersonajeinterfaz.text)
        {

            case  "7":
                 print("personaje1");
                skinrev.SetActive(true);
                 break;
             case "8":
                print("personaje2");
                skincuahu.SetActive(true);
                break;
             default:
                print("personaje default.");
                skincuahu.SetActive(true);
               
                break;
         }

    }
}
