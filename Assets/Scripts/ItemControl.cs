using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
     public Control_Cerdito controlCerdito;


    public bool ActiveShield;

    public GameObject jugador1;
    public GameObject item1TocinoPista;
    public GameObject item2escudo;
    public GameObject item3ManchaPantallaEnemigo;
    public GameObject item4chile;
    public GameObject item5Proyectil;

    public void Start()
    {
      
        controlCerdito = GameObject.FindObjectOfType<Control_Cerdito>();
    }

    public int ChargeItem(int _numRandom)
    {

        _numRandom = Random.Range(1, 5);

        switch (_numRandom)
        {
            case 1:
                PoderItem1();
                Debug.Log("item1: dejar tocino");
                break;
            case 2:
              
                PoderItem2(ActiveShield);
                Debug.Log("item2: escudo");
                break;
            case 3:
              
                PoderItem3();
                Debug.Log("item3: mancha enemigo");
                break;

            case 4:
              
                PoderItem4();
                Debug.Log("item4: aceleracion");
                break;

            case 5:
                PoderItem5();
                Debug.Log("item5: disparar objeto");
                break;

            default:
                Debug.Log("No hay Nada");
                break;

        }

        return _numRandom;

    }


    //Poder de dejar un tocino en la pista

    public void PoderItem1()
    {

        Instantiate(item1TocinoPista, new Vector3(jugador1.transform.position.x, jugador1.transform.position.y+.3f, jugador1.transform.position.z), jugador1.transform.rotation);

    }


    //Poder escudo cerdo
    public void PoderItem2(bool _ActiveShield)
    {
        StartCoroutine(TiempoItem2(_ActiveShield));
    }

    public IEnumerator TiempoItem2(bool _ActiveShield)
    {
        item2escudo.SetActive(true);
        _ActiveShield = true;
 
        yield return new WaitForSeconds(3);

        item2escudo.SetActive(false);
        _ActiveShield = false;

    }

    //Item 3 mancha pantalla del enemigo

    public void PoderItem3()
    {
        StartCoroutine(TiempoItem3());
    }

    IEnumerator TiempoItem3()
    {
        item3ManchaPantallaEnemigo.SetActive(true);
        yield return new WaitForSeconds(3);
        item3ManchaPantallaEnemigo.SetActive(false);

    }


    //Item 4 Aceleracion del personaje

    public void PoderItem4()
    {
        StartCoroutine(TiempoItem4());
    }

    IEnumerator TiempoItem4()
    {
        item4chile.SetActive(true);
        controlCerdito.MaxSpeed=controlCerdito.MaxSpeed * 2.0f;

        yield return new WaitForSeconds(5);

        item4chile.SetActive(false);
        controlCerdito.MaxSpeed = controlCerdito.MaxSpeed / 2.0f;

    }


    //Item 5 Disparar objeto

    public void PoderItem5()
    {
        Instantiate(item5Proyectil, new Vector3(jugador1.transform.position.x, jugador1.transform.position.y, jugador1.transform.position.z + 3), transform.rotation);
    }

}
