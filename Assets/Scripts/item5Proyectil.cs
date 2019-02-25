using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item5Proyectil : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
       this.gameObject=new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
        
    }
}
