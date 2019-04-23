using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class activaranimaciones : MonoBehaviour, Iactivaranimaciones
{
    private ActivaranimacionesEngine _activaranimacionesengine;

 
    //public Rigidbody Cerdito;
    public Animator animacioncerdito; // animator del cerdito

    /// <summary>
    /// cerdito=0 significa animacion de idle
    /// cerdito=1 significa animacion de correr
    /// cerdito=2 significa animacion de frenado //no aplica al no haber aceleracion
    /// cerdito=3 significa animacion de saltoUP
    /// cerdito=4 significa animacion de daño
    /// cerdito=5 significa animacion de saltoDown
    /// cerdito=6 significa animacion de Item
    /// </summary>

    private void Awake()
    {
        _activaranimacionesengine = new ActivaranimacionesEngine(this);
    }


    void Update()
    {

        animacioncerdito.SetInteger("cerdito", _activaranimacionesengine.SeleccionAnimacion());

    }    
    
   
}

public class ActivaranimacionesEngine
{

    private Iactivaranimaciones _activaranimaciones;

    public ActivaranimacionesEngine(Iactivaranimaciones activaranimaciones)
    {
        _activaranimaciones = activaranimaciones;
    }
    
    
    public int SeleccionAnimacion()
    {
        var numeroAnimacion = 0;
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            numeroAnimacion = 1;
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            numeroAnimacion = 3;
        }

        return numeroAnimacion;
    }
}


public interface Iactivaranimaciones
{
    
}
