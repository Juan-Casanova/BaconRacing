using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamaraP2 : MonoBehaviour
{
    //private MovimientoCerdoEngine movimientoCerdoEngine;
    //public Vector3 camara;

    float subir = 0;
    private bool subiendo = true;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoverCamara();
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, 0);
        }
    }

    void MoverCamara()
    {
        if (subiendo)
        {
            this.transform.Rotate(subir, 0, 0);
            subir = subir - .05f;
            if (subir <= -1.0)
            {
                subiendo = false;
            }
            Debug.Log(subir);
        }
        if (!subiendo)
        {
            this.transform.Rotate(subir, 0, 0);
            subir = subir + .05f;
            if (subir >= 1.0)
            {
                subiendo = true;
            }
        }


    }
}
