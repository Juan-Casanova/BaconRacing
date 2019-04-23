using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOut_title : MonoBehaviour
{
    public GameObject Main_Canvas;
    public GameObject Character_Canvas;

    // Update is called once per frame
    void Update()
    {
        if (!Input.anyKey) return;
        Main_Canvas.SetActive(false);
        Character_Canvas.SetActive(true);

    }
}
