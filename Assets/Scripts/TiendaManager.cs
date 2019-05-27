using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class TiendaManager : MonoBehaviour
{
    public Text Saldo;
    
    //int sa = 8;

    Real_Menu_manager realMenuManager=new Real_Menu_manager();

    void Update()
    {
        realMenuManager.Cargar();
        Saldo.text = "Saldo " + realMenuManager.Saldo;
    }
}
