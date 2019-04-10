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



        [Test]
        public void MovimientoCerdo_Move_DoesNotExecutesWhenVerticalOrHorizontalAxisAreZero()
        {
            //Arrange
            MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
            float verticalAxis=0;
            float horizontalAxis = 0;
            float deltaTime = 5.5f;

            var movimientoCerdoSubstitute = new MovimientoCerdoSubstitute();

            //Act
            movimientoCerdoEngine.Move(verticalAxis,horizontalAxis,deltaTime, movimientoCerdoSubstitute);

            //Assert
        
            Assert.IsFalse(movimientoCerdoSubstitute.MoveWasCalled);

        }


        [Test]
        public void MovimientoCerdo_Move_ExecutesWhenVerticalOrHorizontalAxisAreDifferentZero()
        {
            //Arrange
            MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
            float verticalAxis = 2.0f;
            float horizontalAxis = 3.0f;
            float deltaTime = 5.5f;

            var movimientoCerdoSubstitute = new MovimientoCerdoSubstitute();

            //Act
            movimientoCerdoEngine.Move(verticalAxis, horizontalAxis, deltaTime, movimientoCerdoSubstitute);

            //Assert
            Assert.IsTrue(movimientoCerdoSubstitute.MoveWasCalled);

        }
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

