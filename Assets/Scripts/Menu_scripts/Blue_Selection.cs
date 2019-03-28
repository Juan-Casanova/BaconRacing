using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blue_Selection : MonoBehaviour
{
    public static int personajeinterfaz = 0;

    /* public void skinsoff()
     {
         skincuchu.SetActive(false);
         skinrevolucinario.SetActive(false);
     }*/

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Select_Mario()
    {
        Debug.Log("Seleccionando al Mario");
        print("Seleccionando al Mario");
        //skincuchu.SetActive(true);//
        personajeinterfaz = 1;
    }

    public void Select_DK()
    {
        Debug.Log("Seleccionando al DK");
        personajeinterfaz = 2;
    }

    public void Select_Sly()
    {
        Debug.Log("Seleccionando al Sly");
    }

    public void Select_Troll()
    {
        Debug.Log("Seleccionando al Troll");
    }

    public void Select_Sonic()
    {
        Debug.Log("Seleccionando al Sonic");
    }

    public void Select_Crash()
    {
        Debug.Log("Seleccionando al Crash");
    }
}
