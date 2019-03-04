using System.Collections;
using System.Collections.Generic;


public class TakeOut_titleEngine
{
    public bool mainCanvasIsActive, characterCanvasIsActive,pressAnyKey;

    public void pressAnyKeyForShowCnavas()
    {
        if (pressAnyKey)
        {
            mainCanvasIsActive = false;
            characterCanvasIsActive = true;
        }
        else
        {
            mainCanvasIsActive = true;
            characterCanvasIsActive = false;
        }

    }

}
