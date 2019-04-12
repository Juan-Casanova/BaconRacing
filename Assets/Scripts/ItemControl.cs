using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public GameObject jugador;
    public GameObject item1TocinoPista;
    public GameObject item2Proyectil;
    public GameObject item3chile;

    public MovimientoCerdo movimientoCerdo;

    public void Start() => item3chile.SetActive(false);

    public int getItemRandom()=> Random.Range(1, 3);

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

    //Item1 Poder de dejar un tocino en la pista

    public void PoderItem1()=>Instantiate(item1TocinoPista, new Vector3(jugador.transform.position.x, jugador.transform.position.y+.4f, jugador.transform.position.z-.4f), jugador.transform.rotation);
   
    //Item 2 Disparar objeto
    public void PoderItem2() => Instantiate(item2Proyectil, new Vector3(jugador.transform.position.x, jugador.transform.position.y+1.2f, jugador.transform.position.z + 3), transform.rotation);
   
    //Item 3 Aceleracion del personaje

    public void PoderItem3() => StartCoroutine(TiempoItem3());

    IEnumerator TiempoItem3()
    {
        item3chile.SetActive(true);
        movimientoCerdo.movimientoCerdoEngine.speed = 15;
        yield return new WaitForSeconds(5);
        movimientoCerdo.movimientoCerdoEngine.speed = 10;
        item3chile.SetActive(false);
    }
}
