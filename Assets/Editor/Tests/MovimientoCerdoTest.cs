using NUnit.Framework;

namespace Tests
{
	public class MovimientoCerdoTest
    {
        [Test]
        public void MovimientoCerdo_Jump_ExecutesWhenIsJumpingIsTrue()
        {
            //Arrange
            MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
            movimientoCerdoEngine.speed = 10.0f;
            movimientoCerdoEngine.angulo = 3.0f;
            movimientoCerdoEngine.jump = 8.0f;
            movimientoCerdoEngine.maxJumps = 3;

			var movimientoCerdoSubstitute = new MovimientoCerdoSubstitute();

            //Act
            movimientoCerdoEngine.Jump(true, movimientoCerdoSubstitute);

            //Assert
            Assert.IsTrue(movimientoCerdoSubstitute.JumpWasCalled);
            Assert.AreEqual(2, movimientoCerdoEngine.maxJumps);
        }

        [Test]
        public void MovimientoCerdo_Jump_DoesNotExecutesWhenIsJumpingIsFalse()
        {
	        //Arrange
	        MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
	        movimientoCerdoEngine.speed = 10.0f;
	        movimientoCerdoEngine.angulo = 3.0f;
	        movimientoCerdoEngine.jump = 8.0f;
	        movimientoCerdoEngine.maxJumps = 3;

	        var movimientoCerdoSubstitute = new MovimientoCerdoSubstitute();

	        //Act
	        movimientoCerdoEngine.Jump(false, movimientoCerdoSubstitute);

	        //Assert
	        Assert.IsFalse(movimientoCerdoSubstitute.JumpWasCalled);
	        Assert.AreEqual(3, movimientoCerdoEngine.maxJumps);
        }
    }

	public class MovimientoCerdoSubstitute : IMovimientoCerdo
	{
		public bool MoveWasCalled = false;
		public bool JumpWasCalled = false;

		public void Move(float verticalVelocity, float rotation)
		{
			MoveWasCalled = true;
		}

		public void Jump(float jumpForce)
		{
			JumpWasCalled = true;
		}
	}
}
