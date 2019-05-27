using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamaraP1 : MonoBehaviour
{
    //private MovimientoCerdoEngine movimientoCerdoEngine;
    //public Vector3 camara;

    float subir = 0;
    private bool subiendo = true;

    void Update()
    {
        if (Input.GetKey("up"))
        {
            MoverCamara();
        }
        if (Input.GetKey("up"))
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
            if (subir <= -.75f)
            {
                subiendo = false;
            }
            Debug.Log(subir);
        }
        if (!subiendo)
        {
            this.transform.Rotate(subir, 0, 0);
            subir = subir + .05f;
            if (subir >= .75f)
            {
                subiendo = true;
            }
        }


    }
}
