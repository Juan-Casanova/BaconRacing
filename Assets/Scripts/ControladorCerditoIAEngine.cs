using System;
using System.Collections;
using System.Collections.Generic;


public class ControladorCerditoIAEngine
{
    //Controlado_Cerdo_IA controladoCerdoIa;
    public float distance;
    public float minDistance;
    public bool rand;
    public bool go;
    public bool countDownEngine;
    public bool activeMethodMove;
    public int num;
    public int waypoints;
    public int numRandom;

    public void controlCerditoIAEngine()
    {

        if (go && countDownEngine == true)
        {
            if (distance > minDistance)
            {
               // controladoCerdoIa.Move();
                activeMethodMove = true;
            }
            else
            {
                if (!rand)
                {
                    if (num + 1 == waypoints)
                    {
                        num = 0;
                    }
                    else
                    {
                        num++;
                    }
                }
                else
                {
                    num = numRandom;
                }
            }

        }
    }


}
