using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
     public Control_Cerdito controlCerdito;


    public bool ActiveShield;

    public GameObject jugador1;
    public GameObject item1TocinoPista;
    public GameObject item3ManchaPantallaEnemigo;
    public GameObject item5Proyectil;

    public void Start()
    {
        controlCerdito = GameObject.FindObjectOfType<Control_Cerdito>();
    }

    public void ChargeItem(int _numRandom)
    {

        _numRandom = Random.Range(1, 5);

        switch (_numRandom)
        {
            case 1:
                PoderItem5();
                //PoderItem1();
                Debug.Log("item1: dejar tocino");
                break;
            case 2:
                PoderItem5();
                //PoderItem2(ActiveShield);
                Debug.Log("item2: escudo");
                break;
            case 3:
                PoderItem5();
              //  PoderItem3();
                Debug.Log("item3: mancha enemigo");
                break;

            case 4:
                PoderItem5();
                //PoderItem4();
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


    }


    //Poder de dejar un tocino en la pista

    public void PoderItem1()
    {

        Instantiate(item1TocinoPista, jugador1.transform.position, jugador1.transform.rotation);

    }


    //Poder escudo cerdo
    public void PoderItem2(bool _ActiveShield)
    {
      
        StartCoroutine(TiempoItem2(_ActiveShield));
        Debug.Log("Se activo el item2");
    }

    IEnumerator TiempoItem2(bool _ActiveShield=false)
    {
        _ActiveShield = true;
        Debug.Log(_ActiveShield);

        yield return new WaitForSeconds(10);

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
        yield return new WaitForSeconds(5);
        item3ManchaPantallaEnemigo.SetActive(false);

    }


    //Item 4 Aceleracion del personaje

    public void PoderItem4()
    {
        StartCoroutine(TiempoItem4());
    }

    IEnumerator TiempoItem4()
    {
        
        controlCerdito.MaxSpeed=controlCerdito.MaxSpeed * 2.0f;

        yield return new WaitForSeconds(5);


        controlCerdito.MaxSpeed = controlCerdito.MaxSpeed / 2.0f;

    }


    //Item 5 Disparar objeto

    public void PoderItem5()
    {
        Instantiate(item5Proyectil, new Vector3(jugador1.transform.position.x, jugador1.transform.position.y, jugador1.transform.position.z + 3.0f), transform.rotation);
    }

}
