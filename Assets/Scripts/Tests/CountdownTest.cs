using NUnit.Framework;

namespace Tests
{
  
    public class CountdownTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CountdownTestWhenIsTrue()
        {
        
        //Arrange
        CountDownEngine countDownEngine=new CountDownEngine();

        countDownEngine.time = 6.0f;
        countDownEngine.initialCounter = 5.0f;
            bool result;


            //Act
            result = countDownEngine.countdownToActivateMovement();

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CountdownTestWhenIsFalse()
        {

            //Arrange
            CountDownEngine countDownEngine = new CountDownEngine();

            countDownEngine.time = 3.0f;
            countDownEngine.initialCounter = 5.0f;
            bool result;


            //Act
            result = countDownEngine.countdownToActivateMovement();


            //Assert
            Assert.IsFalse(result);

        }
    }
}
