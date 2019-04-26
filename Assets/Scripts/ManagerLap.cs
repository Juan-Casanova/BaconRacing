public class ManagerLap
{

    public int numCheckPlayer1 = 0, numCheckPlayer2 = 0;
    public int lapPlayer1 = 0, lapPlayer2 = 0;

    public void ManageCheckLap(bool comparePlayer,
        ref bool isActivate1,
        ref bool isActivate2)
    {
        if (comparePlayer && !isActivate1)
        {
            isActivate1 = true;
            numCheckPlayer1 +=1;
        }
        else if (!comparePlayer && !isActivate2)
        {
            isActivate2 = true;
            numCheckPlayer2 += 1;
        }
    }

    public void CheckCurrentLap(ref bool isActivate1,
        ref bool isActivate2)
    {
        if (numCheckPlayer1 > 3)
        {
            lapPlayer1 += 1;
            numCheckPlayer1 = 0;
            isActivate1 = false;
        }
        else if (numCheckPlayer2 > 3)
        {
            lapPlayer2 += 1;
            numCheckPlayer2 = 0;
            isActivate2 = false;
        }
    }
}
