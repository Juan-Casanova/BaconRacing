using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilRespawn : MonoBehaviour
{
    private BarrilRespwnEngine _barrilRespawnEngine;
    public void OnTriggerEnter(Collider other) => StartCoroutine(DisapearBarrilForSeconds());
    
    public void Awake() => _barrilRespawnEngine = new BarrilRespwnEngine();

    public IEnumerator DisapearBarrilForSeconds()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 10,this.transform.position.z);
        yield return new WaitForSeconds(3);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 10, this.transform.position.z);
    }
    public void Update() => transform.Rotate(0, 0, _barrilRespawnEngine.Rotacion_Ida_Vuelta());
}
