
using UnityEngine;

public class ManagerLaps : MonoBehaviour
{
    public int LapP1;
    public int LapP2;
    public int numCheckP1 = 0;
    public int numCheckP2 = 0;
    public CheckLap[] checkLap;
 
    public void Update()
    {
        if (numCheckP1 == 4)
        {
            LapP1++;
            numCheckP1 = 0;
            resetChekpoints1();
        }
        else if (numCheckP2 == 4)
        {
            LapP2++;
            numCheckP2 = 0;
            resetChekpoints2();
        }
    }

    public void resetChekpoints1()
    {
        for (int i = 0; i <= checkLap.Length; i++)
        {
            checkLap[i].isActivate1 = false;
        }
    }

    public void resetChekpoints2()
    {
        for (int i = 0; i <= checkLap.Length; i++)
        {
            checkLap[i].isActivate2 = false;
        }
    }
}
