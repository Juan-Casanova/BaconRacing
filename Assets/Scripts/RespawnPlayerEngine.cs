using System.Collections;
using System.Collections.Generic;


public class RespawnPlayerEngine
{
    public int numSpawn;
    

    public int IncreaseNumSpawn()
    {
        if (numSpawn == 0)
        {
            numSpawn += 1;
        }
        else if (numSpawn > 6)
        {
            numSpawn = 0;
        }

        return numSpawn;
    }



}
