using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityModifier : MonoBehaviour
{
    [Range(0, 1)]
    public float reduccion = 0.5f;

    VelocityModiferEngine _velocityModiferEngine= new VelocityModiferEngine();

    public float duration = 2;

    public bool picked = false;
    public MeshRenderer renderer;
    private MovimientoCerdo cerdito;
    public void OnTriggerEnter(Collider other)
    {
        _velocityModiferEngine.CompararTagCerdo(other, picked,
            reduccion, renderer);
        //if (other.CompareTag("Player") && !picked)
        //{
        //    picked = true;
        //    cerdito = other.GetComponent<MovimientoCerdo>();
        //    cerdito.movimientoCerdoEngine.speed *= reduccion;
        //    renderer.enabled = false;
        //    StartCoroutine(cancelEffect());
        //}
    }

    public IEnumerator cancelEffect()
    {
        yield return new WaitForSeconds(duration);
        Debug.Log("Me destruyo papu");
        cerdito.movimientoCerdoEngine.speed = cerdito.BaseSpeed;
        Destroy(gameObject);
    }
}
