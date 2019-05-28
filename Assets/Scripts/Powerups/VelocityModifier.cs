using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityModifier : MonoBehaviour
{
    [Range(0, 1)]
    public float reduccion = 0.5f;

    public float duration = 2;
    public Animator animacionitem; // animator del item //probandose
    public bool picked = false;
    public MeshRenderer renderer;
    private MovimientoCerdo cerdito;
   

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !picked)
        {
            picked = true;
            cerdito = other.GetComponent<MovimientoCerdo>();
            cerdito.movimientoCerdoEngine.speed *= reduccion;
            renderer.enabled = false;
            if (this.gameObject.tag == "tocinito")
            {
                cerdito.bacon.SetActive(true);
            }
            else if (this.gameObject.tag == "botellita")
            {
                cerdito.star.SetActive(true);
            }


            StartCoroutine(cancelEffect());
        }
    }

    public IEnumerator cancelEffect()
    {
        yield return new WaitForSeconds(duration);
        Debug.Log("Me destruyo papu");
        cerdito.movimientoCerdoEngine.speed = cerdito.BaseSpeed;

         cerdito.star.SetActive(false);
         cerdito.bacon.SetActive(false);
        Destroy(gameObject);
    }
}
