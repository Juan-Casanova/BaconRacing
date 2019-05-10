using UnityEngine;

public class ActivaranimacionesEngine
{



    public int numeroAnimacion, numeroAnimacionPersonaje;
    public int numeroAnimacion2P, numeroAnimacionPersonaje2P;

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

    public int SeleccionAnimacion2P()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            numeroAnimacion2P = 1;
        
        } else if (Input.GetKeyDown(KeyCode.Q))
        {
            numeroAnimacion2P = 3;
        }
        else
        {
            numeroAnimacion2P = 0;
        }
        
        return numeroAnimacion2P;
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
    
    public int SeleccionAnimacion2PforTest()
    {
        int result_local;
        
        if (numeroAnimacion2P == 1)
        {
            result_local = 1;  
        }else if (numeroAnimacion2P == 3)
        {
            result_local = 3;
        }
        else
        {
            result_local = 0;
        }

        return result_local;
    }



    //para animacion del personaje
    public int SeleccionAnimacionPersonaje()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            numeroAnimacionPersonaje = 1;
        }
        else
        {
            numeroAnimacionPersonaje = 0;
        }

        return numeroAnimacionPersonaje;
    }

    public int SeleccionAnimacionPersonaje2P()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            numeroAnimacionPersonaje2P = 1;

        }
        else
        {
            numeroAnimacionPersonaje2P = 0;
        }

       return numeroAnimacionPersonaje2P;
    }


}