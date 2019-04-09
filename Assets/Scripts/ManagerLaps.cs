using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLaps : MonoBehaviour
{
    public int LapP1;
    public int LapP2;
    public int numCheckP1 = 0;
    public int numCheckP2 = 0;
    public bool[] isActivate;
   

    public void Update()
    {
        if (numCheckP1 == 4)
        {
            LapP1++;
            numCheckP1 = 0;
            for (int i = 0; i < 5; i++)
            {
                isActivate[i] = false;
            }

        }
        else if (numCheckP2 == 4)
        {
            LapP2++;
            numCheckP2 = 0;
            for (int i = 5; i < 9; i++)
            {
                isActivate[i] = false;
            }

        }
    }


}
