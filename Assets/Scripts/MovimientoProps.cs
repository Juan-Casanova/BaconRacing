using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProps : MonoBehaviour
{
    float rotateRana;
    float rotateAbanico;

    public void Update()
    {
        

        if (this.gameObject.CompareTag("rana"))
        {

            rotateRana = rotationObject(rotateRana);
            this.gameObject.transform.Rotate(new Vector3(0.0f, rotateRana, 0.0f));
        }
        else if (this.gameObject.CompareTag("abanico"))
        {
            rotateAbanico = rotationObject(rotateAbanico);
            this.gameObject.transform.Rotate(new Vector3(rotateAbanico, 0.0f, 0.0f));
        }
           
    
    }

    public float rotationObject(float _rotation)
    {
        
       
        if (_rotation > 1.0f)
        {
            _rotation -= 0.05f;
        }
        else if (_rotation < -1.0f || _rotation<=0)
        {
            _rotation += 0.05f;
        }

     
        return _rotation;
    }
}
