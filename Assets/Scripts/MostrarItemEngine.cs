
using UnityEngine;

public class MostrarItemEngine
{
    private int input_regreso = 0;
    
    public void ShowItemTest(int _numItem)
    {
        
        switch (_numItem)
        {
            case 1:
                input_regreso = 1;

                break;
            case 2:
                input_regreso = 2;

                break;
            case 3:
                input_regreso = 3;
                break;
             default:

                break;
        }
    }
    
    
}
