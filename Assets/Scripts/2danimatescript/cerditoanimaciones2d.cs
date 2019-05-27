using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerditoanimaciones2d : MonoBehaviour
{
    public Animator animatorItems, animatorItems2;
    public ScriptableObject SmovimientocerdoP1, SmovimientocerdoP2;
    void Start()
    {
        
    }

 
    public void itemfuego()
    {
        animatorItems.SetInteger("reaccionesitems", 3);
    }
    public void itemEstrella()
    {
        animatorItems.SetInteger("reaccionesitems", 2);
    }
    public void itemTocino()
    {
        animatorItems.SetInteger("reaccionesitems", 1);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("EXITO??");
                        itemfuego();
            Debug.Log("creo que ...??");
        }
        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("EXITO??");

            itemEstrella();
            Debug.Log("creo que ...??");
        }

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("EXITO??");

            itemTocino();
            Debug.Log("creo que ...??");
        }

    }
}
