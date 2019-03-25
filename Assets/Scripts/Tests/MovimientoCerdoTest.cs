using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovimientoCerdoTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MovimientoCerdoTestGetVelocityVertical()
        {
            //Arrange
            MovimientoCerdoEngine movimientoCerdoEngine = new MovimientoCerdoEngine();
            movimientoCerdoEngine.speed = 10.0f;
            movimientoCerdoEngine.angulo = 3.0f;
            movimientoCerdoEngine.jump = 8.0f;
            movimientoCerdoEngine.maxJumps = 3;
            movimientoCerdoEngine.time =
            movimientoCerdoEngine.vertical = 0.7f;
            movimientoCerdoEngine.horizontal = 0.2f;
            float result;

            //Act
            result = movimientoCerdoEngine.getVelocityV();

            //Assert
            Assert.Greater(result, 0);

        }

     
    }
}
