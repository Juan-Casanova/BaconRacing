using UnityEngine;

public class ActivaranimacionesEngine
{

    

    public int numeroAnimacion;

    public int SeleccionAnimacion()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            numeroAnimacion = 1;
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            numeroAnimacion = 3;
        }
        else
        {
            numeroAnimacion = 0;
        }
        
        return numeroAnimacion;
    }

    public int SeleccionAnimacionforTest()
    {
        int result_local;
        
        if (numeroAnimacion == 1)
        {
            result_local = 1;  
        }else if (numeroAnimacion == 3)
        {
            result_local = 3;
        }
        else
        {
            result_local = 0;
        }

        return result_local;
    }
}