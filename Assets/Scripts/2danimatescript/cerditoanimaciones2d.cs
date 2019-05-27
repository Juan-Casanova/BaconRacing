using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cerditoanimaciones2d : MonoBehaviour
{
    public Animator animatorItems, animatorItems2;
    public ScriptableObject SmovimientocerdoP1, SmovimientocerdoP2;
    public MovimientoCerdo movimientoCerdo=new MovimientoCerdo();
    public GameObject j1Tocino, j1Fuego, j1Botella;
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
    public int numeroanim;
    public void Update()
    {
        //numeroanim = movimientoCerdo.numnum;
        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("EXITO??");
                        itemfuego();
            j1Tocino.SetActive(false);
            j1Fuego.SetActive(true);
            j1Botella.SetActive(false);
            Debug.Log("creo que ...??");
        }
        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("EXITO??");

            itemEstrella();
            j1Tocino.SetActive(false);
            j1Fuego.SetActive(false);
            j1Botella.SetActive(true);
            Debug.Log("creo que ...??");
        }

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("EXITO??");

            itemTocino();
            j1Tocino.SetActive(true);
            j1Fuego.SetActive(false);
            j1Botella.SetActive(false);

            Debug.Log("creo que ...??");
        }

    }
}
