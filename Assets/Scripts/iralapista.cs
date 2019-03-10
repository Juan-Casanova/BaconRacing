using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iralapista : MonoBehaviour
{
     public string escenaacambiar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

    }
 

    public void irotraescena()
    {
        Debug.Log("hooooola");
       
            SceneManager.LoadScene("Pista_China");// enl nombre de la escena a la que va a ir (entre parentesis)
        
       
    }

}
