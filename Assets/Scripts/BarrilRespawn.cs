using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilRespawn : MonoBehaviour
{

    public void OnTriggerEnter(Collider other) => StartCoroutine(DisapearBarrilForSeconds());

    public IEnumerator DisapearBarrilForSeconds()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 10,this.transform.position.z);
        yield return new WaitForSeconds(3);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 10, this.transform.position.z);
    }
    public void Update() => transform.Rotate(0, 0, 2.5f);
}
