using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOut_title : MonoBehaviour
{
    private TakeOut_titleEngine takeOutTitleEngine;
    public bool mainCanvasIsActive, characterCanvasIsActive, pressAnyKey;

    public GameObject Main_Canvas;
    public GameObject Character_Canvas;

    // Update is called once per frame
    void Update()
    {
        takeOutTitleEngine.pressAnyKey = Input.anyKey;

        takeOutTitleEngine.pressAnyKeyForShowCnavas();

            Main_Canvas.SetActive(takeOutTitleEngine.mainCanvasIsActive);
            Character_Canvas.SetActive(takeOutTitleEngine.characterCanvasIsActive);

    }
}
