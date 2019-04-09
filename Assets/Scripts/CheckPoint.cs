
using NUnit.Framework.Constraints;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public bool isActive1=false;
    public bool isActive2 = false;


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player1")&&!isActive1)
        {
            isActive1 = true;

        }else if(other.CompareTag("Player2") && !isActive2)
        {
            isActive2 = true;
        }

    }


}
