using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blue_Selection : MonoBehaviour
{
    public static int personajeinterfaz = 0;

    private void Awake() => DontDestroyOnLoad(gameObject);

    public void Select_Mario() => personajeinterfaz = 1;

    public void Select_Crash() => personajeinterfaz = 2;


    public void Select_Mario2() => personajeinterfaz = 7;

    public void Select_Crash2() => personajeinterfaz = 8;
}
