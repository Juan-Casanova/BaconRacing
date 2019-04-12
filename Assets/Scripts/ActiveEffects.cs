using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEffects : MonoBehaviour
{
    public enum numPlayer
    {
        p1,
        p2
    }
    public numPlayer NumPlayer;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ItemTocinoText(Clone)") Debug.Log("jajajajaja");
        if (other.gameObject.name == "ItemTocinoText(Clone)") Debug.Log("jajajajaja");
    }

    public void FixedUpdate()
    {
        string playerSuffix = NumPlayer == 0 ? "" : "2";
    }
}
