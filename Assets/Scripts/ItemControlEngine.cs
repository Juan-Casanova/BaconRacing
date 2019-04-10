
public class ItemControlEngine
{
    public void ChargeItem(int numRandom,IItemControl itemControl)
    {
        switch (numRandom)
        {
            case 1:
                itemControl.PoderItem1();
                break;
            case 2:
                itemControl.PoderItem2();
                break;
            case 3:
                itemControl.PoderItem3();
                break;
            default:
            
                break;
        }
    }


}

public interface IItemControl
{
    void PoderItem1();
    void PoderItem2();
    void PoderItem3();

}