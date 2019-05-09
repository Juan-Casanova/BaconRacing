using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaEngine
{

    public void Vueltas(string GamerTag, int Checkpoint, int Index, ref int currentlap, ref int currentCheckPoint, IMeta _Meta,GameObject _GameOver )
    {
        
            if (GamerTag == "Player" && Checkpoint == Index -1)
            {
            
                currentlap++;
                currentCheckPoint = 0;
                if (currentlap >= 3)
                {
                    //    GameManager.instancia.GameOver(other.gameObject);
                    _Meta.GameOver(_GameOver);
                }
            }
        

    }
}
    
