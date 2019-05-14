using UnityEngine;

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

    public void AumentarVelocidadCerdo(float aumento)
    {
        speed *= aumento;
    }

    public void AsignarspeedaBase(float BaseSpeed)
    {
        speed = BaseSpeed;
    }

    public bool Cambiarafalso()
    {
        return false;
    }

    public void Asignar_Valor_de_speed(float _speed)
    {
        speed = _speed;
    }

    public void Asignar_Angulo()
    {
        angulo = 3.0f;
    }

    public void Asignar_JumpForce(float _jumpForce)
    {
        jump = _jumpForce;
    }

    public void Asignar_MaxJumps()
    {
        maxJumps = 3;
    }

}