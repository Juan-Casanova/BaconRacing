using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blue_Selection : MonoBehaviour
{
    public static int personajeinterfaz = 0;

    private void Awake() => DontDestroyOnLoad(gameObject);

    public void Select_Mario() => personajeinterfaz = 1;

}
