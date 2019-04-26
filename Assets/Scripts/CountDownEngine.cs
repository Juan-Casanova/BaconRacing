public class CountDownEngine
{
    /// <summary>
    /// Es desde donde comienza el contador inicial
    /// </summary>
    public float initialCounter;

    /// <summary>
    /// Es la variable que representa a time.deltatime
    /// </summary>
    public float time;

    public bool countdownToActivateMovement()
    {
        initialCounter -= time;

        return initialCounter <= 0;
    }
}
