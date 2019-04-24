using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item5Proyectil : MonoBehaviour
{
    float velocidad = 10f;

    public void Start()=> StartCoroutine(destroyObject());



    // Update is called once per frame
     public void Update()=>transform.Translate(0,0, velocidad * (Time.deltaTime*3));


    public void  OnCollisionEnter(Collision collision) =>Destroy(gameObject);
   
    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }




}
