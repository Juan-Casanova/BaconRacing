using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiendaManager : MonoBehaviour
{
    public Text SaldoTextInsuficiente;

    //Real_Menu_manager realMenuManager;


    public int PistaMexicoActiva;
    public int PistaBosqueActiva;
    public int PistaFranciaActiva;
    public int PistaSaltarinaActiva;
    public int Saldo;

    public void ActualizarVal()
    {
        PistaMexicoActiva = PlayerPrefs.GetInt("PistaMexicoActiva");
        PistaBosqueActiva = PlayerPrefs.GetInt("PistaBosqueActiva");
        PistaFranciaActiva = PlayerPrefs.GetInt("PistaFranciaActiva");
        PistaSaltarinaActiva = PlayerPrefs.GetInt("PistaSaltarinaActiva");
        Saldo = PlayerPrefs.GetInt("Saldo");
    }

    public void Start()
    {
        Debug.Log(Saldo);
    }

    public void ComprarMexico()
    {
        ActualizarVal();
        if (Saldo >= 12)
        {
            PlayerPrefs.SetInt("PistaMexicoActiva", 1);
        }
        else
        {
            SaldoTextInsuficiente.enabled = true;
        }
}

    public void ComprarBosque()
    {
        ActualizarVal();
        if (Saldo >= 16)
        {
            PlayerPrefs.SetInt("PistaBosqueActiva", 1);
        }
        else
        {
            SaldoTextInsuficiente.enabled = true;
        }
    }
    public void ComprarFrancia()
    {
        ActualizarVal();
        if (Saldo >= 16)
        {
            PlayerPrefs.SetInt("PistaFranciaActiva", 1);
        }
        else
        {
            SaldoTextInsuficiente.enabled = true;
        }
    }
    public void ComprarSaltarina()
    {
        ActualizarVal();
        if (Saldo >= 16)
        {
            PlayerPrefs.SetInt("PistaSaltarinaActiva", 1);
        }
        else
        {
            SaldoTextInsuficiente.enabled = true;
        }
    }

    public void AgregarSaldo()
    {
        PlayerPrefs.SetInt("Saldo",+100);
        //PlayerPrefs.SetInt("Saldo", +1);
        Saldo = PlayerPrefs.GetInt("Saldo");
        Debug.Log(Saldo);
    }

    public void Regresar(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }

}
