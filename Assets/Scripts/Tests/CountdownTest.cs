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
            var countDownEngine=new CountDownEngine();
            float time = 4.0f;
            countDownEngine.initialCounter = 2.0f;
          
            bool activateMovement=false;
            
            //Act
            activateMovement = countDownEngine.activateMovementEngine(time);

            //Assert
            Assert.IsTrue(activateMovement);

        }


        [Test]
        public void CountdownTestWhenIsFalse()
        {
            //Arrange
            var countDownEngine = new CountDownEngine();
            float time = 1.0f;
            countDownEngine.initialCounter = 5.0f;

            bool activateMovement = false;

            //Act
            activateMovement = countDownEngine.activateMovementEngine(time);

            //Assert
            Assert.IsFalse(activateMovement);

        }
    }
}
