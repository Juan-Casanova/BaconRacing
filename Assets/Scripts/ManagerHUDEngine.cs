
public class ManagerHUDEngine
{
    public bool isMovementActive = false;
    public bool isInstructionsP1Active = true;
    public bool isInstructionsP2Active = true;
    public string t_posPlayer1, t_posPlayer2,
        t_laps1, t_laps2,
        t_coutndown;
    public float distanceP1;
    public float distanceP2;
    public int lapP1;
    public int lapP2;
    public float initialCounter;

    public void HideScreens(IManagerHUD iManagerHud)
    {
        iManagerHud.HideScreens();
    }

    public void ActivateHUD()
    {
        if (isMovementActive)
        {
            isInstructionsP1Active = false;
            isInstructionsP2Active = false;
        }

        t_coutndown =isMovementActive ? t_coutndown = "" : initialCounter.ToString("f0");

        t_posPlayer1 = distanceP1 >= distanceP2 ? "POS: " + "1" + "/2" : "POS: " + "2" + "/2";
        t_posPlayer2 = distanceP2 >= distanceP1 ? "POS: " + "1" + "/2" : "POS: " + "2" + "/2";

        t_laps1 = "LAP: " + lapP1 + "/2";
        t_laps2 = "LAP: " + lapP2 + "/2";
    }


}


public interface IManagerHUD
{
    void HideScreens();
}