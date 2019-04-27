using UnityEngine;
public class BarrilRespwnEngine
{
    public static float Rotacion = 0;

    public float Rotacion_Ida_Vuelta()
    {
        
        if (Rotacion <= 6)
        {
            Rotacion += .25f;
        }
        else
        {
            Rotacion -= .25f;
        }
        
        return Rotacion;
    }
    
}
