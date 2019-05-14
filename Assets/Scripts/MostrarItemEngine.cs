public class MostrarItemEngine
{
    public IMostrarItem MostrarItem;

    public IOcultarItem OcultarItem;

    public MostrarItemEngine(IMostrarItem mostrarItem,IOcultarItem ocultarItem)
    {
	    MostrarItem = mostrarItem;
        OcultarItem = ocultarItem;
    }
    //public OcultarItemEngine(IOcultarItem ocultarItem)
    //{
    //    OcultarItem = ocultarItem;
    //}


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

    public void HideItems(int _numItem, numPlayer numPlayer)
    {
        switch (_numItem)
        {
            case 1:
                OcultarItem.HideIconItem(numPlayer == numPlayer.p1 ? 0 : 3);

                break;
            case 2:
                OcultarItem.HideIconItem(numPlayer == numPlayer.p1 ? 2 : 5);


                break;
            case 3:
                OcultarItem.HideIconItem(numPlayer == numPlayer.p1 ? 1 : 4);

                break;
            default:
                OcultarItem.HideAllItems();
                break;
        }
    }
}