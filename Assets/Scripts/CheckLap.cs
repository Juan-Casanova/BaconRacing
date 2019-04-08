using System.Collections;
using UnityEngine;

public class CheckLap : MonoBehaviour
{
    public int lapP1 = 0;
    public int lapP2 = 0;
    public MovimientoCerdo movimientoCerdoP1, movimientoCerdoP2;
    public GameObject meta;

    private void OnTriggerEnter(Collider other)
    {
        if(movimientoCerdoP1)
        {
            lapP1++;
            StartCoroutine(activateMeta());
        }
        else if(movimientoCerdoP2)
        {
            lapP2++;
            StartCoroutine(activateMeta());
        }
    }

    private IEnumerator activateMeta()
    {
        meta.SetActive(false);
        yield return new WaitForSeconds(3);
        meta.SetActive(true);
    }

}
