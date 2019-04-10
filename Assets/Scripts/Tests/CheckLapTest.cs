
using NUnit.Framework;

namespace Tests
{
    public class CheckLapTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CheckLapTest_ManageCheckLap_WhenIsActivate1TrueAndComparePlayerIsTrue()
        {
            //Arrange
            CheckLapEngine checkLapEngine = new CheckLapEngine();
            checkLapEngine.isActivate1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.isActivate2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = true;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer);

           //Assert
           Assert.IsTrue(checkLapEngine.isActivate1);
           Assert.AreEqual(2, checkLapEngine.numCheckPlayer1);

        }

        // A Test behaves as an ordinary method
        [Test]
        public void CheckLapTest_ManageCheckLap_WhenIsActivate1FalseAndComparePlayerIsTrue()
        {
            //Arrange
            CheckLapEngine checkLapEngine = new CheckLapEngine();
            checkLapEngine.isActivate1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.isActivate2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = false;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer);

            //Assert
            Assert.IsFalse(checkLapEngine.isActivate1);
            Assert.AreEqual(1, checkLapEngine.numCheckPlayer1);

        }


        // A Test behaves as an ordinary method
        [Test]
        public void CheckLapTest_ManageCheckLap_WhenIsActivate2TrueAndComparePlayerIsFalse()
        {
            //Arrange
            CheckLapEngine checkLapEngine = new CheckLapEngine();
            checkLapEngine.isActivate1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.isActivate2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = false;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer);

            //Assert
            Assert.IsTrue(checkLapEngine.isActivate2);
            Assert.AreEqual(2, checkLapEngine.numCheckPlayer2);

        }

        // A Test behaves as an ordinary method
        [Test]
        public void CheckLapTest_ManageCheckLap_WhenIsActivate2FalseAndComparePlayerIsFalse()
        {
            //Arrange
            CheckLapEngine checkLapEngine = new CheckLapEngine();
            checkLapEngine.isActivate1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.isActivate2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = true;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer);

            //Assert
            Assert.IsFalse(checkLapEngine.isActivate2);
            Assert.AreEqual(1, checkLapEngine.numCheckPlayer2);

        }
    }
}
