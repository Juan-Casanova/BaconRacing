public class MovimientoCerdoEngine
{
	public float angulo;

	public float speed;
	public float jump;
	public int maxJumps;

	public void Jump(bool isJumping, IMovimientoCerdo movimientoCerdoObject)
	{
		if (isJumping && maxJumps > 0)
		{
			movimientoCerdoObject.Jump(jump);
			maxJumps--;
		}
	}

	public void Move(float verticalAxis, 
		float horizontalAxis, float deltaTime, IMovimientoCerdo movimientoCerdoObject)
	{
		if (verticalAxis != 0 || horizontalAxis != 0)
		{
			movimientoCerdoObject.Move(
				verticalAxis * speed * deltaTime,
				horizontalAxis * angulo);
		}
	}
}