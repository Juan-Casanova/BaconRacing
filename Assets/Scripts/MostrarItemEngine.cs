public class MostrarItemEngine
{
    public IMostrarItem MostrarItem;

    public MostrarItemEngine(IMostrarItem mostrarItem)
    {
	    MostrarItem = mostrarItem;
    }

    public void ShowItems(int _numItem, numPlayer numPlayer)
    {
        switch (_numItem)
        {
            case 1:
	            MostrarItem.ShowIconItem(numPlayer == numPlayer.p1 ? 0 : 3);
	            break;
            case 2:
	            MostrarItem.ShowIconItem(numPlayer == numPlayer.p1 ? 2 : 5);
	            break;
            case 3:
	            MostrarItem.ShowIconItem(numPlayer == numPlayer.p1 ? 1 : 4);
	            break;
            default:
                MostrarItem.HideAllItems();
                break;
        }
    }
}