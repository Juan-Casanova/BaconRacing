using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;


namespace Tests
{

    public class CountdownTestEngine
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CountdownTestWhenIsTrue()
        {
            //Arrange
         
            float time = 1.0f;
            float initialCounter=1.0f;
          
            bool activateMovement=false;
            
            //Act
            activateMovement = activateMovementEngine(time, initialCounter);

            //Assert
            Assert.IsTrue(activateMovement);

        }
    }
}
