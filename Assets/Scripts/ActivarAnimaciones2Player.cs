﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAnimaciones2Player : MonoBehaviour
{
   
    private ActivaranimacionesEngine _activaranimacionesengine;


    //public Rigidbody Cerdito;
    public Animator animacioncerdito; // animator del cerdito
    public Animator animacionpersonaje; // animator del personaje

    /// <summary>
    /// cerdito=0 significa animacion de idle
    /// cerdito=1 significa animacion de correr
    /// cerdito=2 significa animacion de frenado //no aplica al no haber aceleracion
    /// cerdito=3 significa animacion de saltoUP
    /// cerdito=4 significa animacion de daño
    /// cerdito=5 significa animacion de saltoDown
    /// cerdito=6 significa animacion de Item
    /// </summary>

    private void Awake()=> _activaranimacionesengine = new ActivaranimacionesEngine();

    private void Update()
    {   animacioncerdito.SetInteger("cerdito", _activaranimacionesengine.SeleccionAnimacion2P());
        animacionpersonaje.SetInteger("personaje", _activaranimacionesengine.SeleccionAnimacionPersonaje2P());  }


}
