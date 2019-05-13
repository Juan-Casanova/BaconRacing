using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityModiferEngine
{
    private MovimientoCerdo cerdito;
    public void CompararTagCerdo(Collider other, bool picked,float reduccion,MeshRenderer renderer)
    {

        if (other.CompareTag("Player") && !picked)
        {
            picked = true;
            cerdito = other.GetComponent<MovimientoCerdo>();
            cerdito.movimientoCerdoEngine.speed *= reduccion;
            renderer.enabled = false;
            //StartCoroutine(cancelEffect());
        }
    }
}
