using NUnit.Framework;

namespace Tests
{
	public class CountdownTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CountdownTestSimplePasses()
        {
            //Arrange
            var countDownEngine = new CountDownEngine();
            countDownEngine.Counter = 8000;
            var deltaTime = 0.0001f;
            
            //Act
            var result = countDownEngine.ShouldActivateMovement(deltaTime);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CountdownTestSimplePasses2()
        {
	        //Arrange
	        var countDownEngine = new CountDownEngine();
	        countDownEngine.Counter = 5;
	        var deltaTime = 10f;
            
	        //Act
	        var result = countDownEngine.ShouldActivateMovement(deltaTime);

	        //Assert
	        Assert.IsTrue(result);
        }
    }
}
