using System.Collections;
using UnityEngine;

public class CheckLap : MonoBehaviour
{
    public int lapP1 = 0;
    public int lapP2 = 0;



    private void Start()
    {
        ResetCheckPointsForLaps();
    }

    private void ResetCheckPointsForLaps()
    {
        for (int i = 0; i < checkPointsForLaps.Length; i++)
        {
            checkPointsForLaps[i] = false;
        }
    }

    private void IncreaseNumLap(int lap)
    {
        ResetCheckPointsForLaps();
        lap++;
    }
  
}
