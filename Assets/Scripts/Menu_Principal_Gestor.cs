using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Principal_Gestor : MonoBehaviour
{
    public GameObject BotonJugar;
        public GameObject UnJugador;
        public GameObject DosJugadores;
    
    public GameObject BotonOpciones;
    public GameObject BotonSalir;


    public void JugarJuego(){
        BotonJugar.SetActive(false);
            UnJugador.SetActive(true);
            DosJugadores.SetActive(true);
        
        BotonOpciones.SetActive(false);

        BotonSalir.SetActive(false);
    }
    public void NextScene(string _scene)
    {
        SceneManager.LoadScene(_scene, LoadSceneMode.Single);
    }


  
}