public class CountDownEngine
{
	public float Counter;

	public bool ShouldActivateMovement(float deltaTime)
	{
		Counter -= deltaTime;
		return Counter <= 0;
	}
}