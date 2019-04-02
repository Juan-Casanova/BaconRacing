using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public GameObject jugador;
    public GameObject item1TocinoPista;
    public GameObject item2chile;
    public GameObject item3Proyectil;

    public MovimientoCerdoEngine movimientoCerdoEngine=new MovimientoCerdoEngine();
    public MovimientoCerdo movimientoCerdo = new MovimientoCerdo();

    public int GetItemRandom()=> Random.Range(1, 5);

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

    //Item 1 Deja un tocino en la pista

    public void PoderItem1()=> Instantiate(item1TocinoPista, new Vector3(jugador.transform.position.x, jugador.transform.position.y+.3f, jugador.transform.position.z), jugador.transform.rotation);

    //Item 2 Aceleracion del personaje
    public void PoderItem2() => StartCoroutine(TiempoItem2());

    IEnumerator TiempoItem2()
    {
        item2chile.SetActive(true);
        movimientoCerdo.movimientoCerdoEngine.speed = 15;
        yield return new WaitForSeconds(5);
        item2chile.SetActive(false);
        movimientoCerdo.movimientoCerdoEngine.speed = 10;
    }

    //Item 3 Disparar objeto

    public void PoderItem3() => Instantiate(item3Proyectil, new Vector3(jugador.transform.position.x, jugador.transform.position.y+1.5f, jugador.transform.position.z + 4), transform.rotation);
 
}
