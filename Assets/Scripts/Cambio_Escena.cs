using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_Escena : MonoBehaviour
{
    public void Escribe_Escena(string _scene)
    {
        SceneManager.LoadScene(_scene, LoadSceneMode.Single);
    }

    public void SalirJuego(){
        Debug.Log("Saliendo del Juego");
        Application.Quit();
    }
}
