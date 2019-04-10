
using UnityEngine;

public class CheckLapEngine:MonoBehaviour
{
    public bool isActivate1,isActivate2;
    public int numCheckPlayer1=0,numCheckPlayer2=0;
    public int lapPlayer1=0, lapPlayer2=0;

    public void ManageCheckLap(bool comparePlayer)
    {
        if (comparePlayer && !isActivate1)
        {
            isActivate1 = true;
            numCheckPlayer1 += 1;
        }else if (!comparePlayer && !isActivate2)
        {
            isActivate2 = true;
            numCheckPlayer2 += 1;
        }
    }

    public void CheckCurrentLap()
    {
        if (numCheckPlayer1 > 3)
        {
            lapPlayer1+=1;
            numCheckPlayer1 = 0;
        }else if (numCheckPlayer2 > 3)
        {
            lapPlayer2+=1;
            numCheckPlayer2 = 0;
        }
    }
}
