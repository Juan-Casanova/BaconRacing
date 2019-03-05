using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProps : MonoBehaviour
{
    private MovimientoPropsEngine movimientoPropsEngine=new MovimientoPropsEngine();
    float rotateRana;
    float rotateAbanico;

    public void Update()
    {

        if (this.gameObject.CompareTag("rana"))
        {

            rotateRana = movimientoPropsEngine.rotationObject();
            this.gameObject.transform.Rotate(new Vector3(0.0f, rotateRana, 0.0f));
        }
        else if (this.gameObject.CompareTag("abanico"))
        {
            rotateAbanico = movimientoPropsEngine.rotationObject();
            this.gameObject.transform.Rotate(new Vector3(rotateAbanico, 0.0f, 0.0f));
        }

    }

}
