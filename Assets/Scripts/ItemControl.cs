using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public GameObject jugador1;
    public GameObject item1TocinoPista;
    public GameObject item2chile;
    public GameObject item3Proyectil;

    public MovimientoCerdo movimientoCerdo=new MovimientoCerdo();


    public int getItemRandom()
    {
        return Random.Range(1, 3);
    }

    public void ChargeItem(int numRandom)
    {

        switch (numRandom)
        {
            case 1:
                PoderItem1();
                
                break;
            case 2:
                PoderItem2();
                
                break;
            case 3:
                PoderItem3();
                
                break;

            default:
                Debug.Log("No hay Nada");
                break;
        }

    }

    //Item 1 Dejar Tocino en la pista

    public void PoderItem1()
    {
        Instantiate(item1TocinoPista, new Vector3(jugador1.transform.position.x, jugador1.transform.position.y+.3f, jugador1.transform.position.z), jugador1.transform.rotation);
    }


    //Item 2 Aceleracion del personaje

    public void PoderItem2()
    {
        StartCoroutine(TiempoItem2());
    }

    IEnumerator TiempoItem2()
    {
        movimientoCerdo.movimientoCerdoEngine.speed *= 2;
        yield return new WaitForSeconds(5);
        movimientoCerdo.movimientoCerdoEngine.speed /= 2;

    }

    //Lanzar Botella
    public void PoderItem3()
    {
        Instantiate(item3Proyectil, new Vector3(jugador1.transform.position.x, jugador1.transform.position.y, jugador1.transform.position.z + 3), transform.rotation);
    }

}
