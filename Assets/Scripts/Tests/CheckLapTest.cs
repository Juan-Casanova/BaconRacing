
using NUnit.Framework;

namespace Tests
{
    public class CheckLapTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ManagerLap_ManageCheckLap_WhenIsActivate1TrueAndComparePlayerIsTrue()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            bool isActivateTest1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            bool isActivateTest2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = true;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer,
                ref isActivateTest1,
                ref isActivateTest2);

           //Assert
           Assert.IsTrue(isActivateTest1);
           Assert.AreEqual(2, checkLapEngine.numCheckPlayer1);

        }

        // A Test behaves as an ordinary method
        [Test]
        public void ManagerLap_ManageCheckLap_WhenIsActivate1FalseAndComparePlayerIsTrue()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            bool isActivateTest1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            bool isActivateTest2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = false;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer,
                ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.IsFalse(isActivateTest1);
            Assert.AreEqual(1, checkLapEngine.numCheckPlayer1);

        }


        // A Test behaves as an ordinary method
        [Test]
        public void ManagerLap_ManageCheckLap_WhenIsActivate2TrueAndComparePlayerIsFalse()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            bool isActivateTest1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            bool isActivateTest2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = false;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer,
                ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.IsTrue(isActivateTest2);
            Assert.AreEqual(2, checkLapEngine.numCheckPlayer2);

        }

        // A Test behaves as an ordinary method
        [Test]
        public void ManagerLap_ManageCheckLap_WhenIsActivate2FalseAndComparePlayerIsFalse()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            bool isActivateTest1 = false;
            checkLapEngine.numCheckPlayer1 = 1;
            bool isActivateTest2 = false;
            checkLapEngine.numCheckPlayer2 = 1;
            bool comparePlayer = true;


            //Act
            checkLapEngine.ManageCheckLap(comparePlayer,
                ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.IsFalse(isActivateTest2);
            Assert.AreEqual(1, checkLapEngine.numCheckPlayer2);

        }

        [Test]
        public void ManagerLap_CheckCurrentLap_WhenNumCheckPlayer1GreaterThree()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            checkLapEngine.lapPlayer1 = 0;
            checkLapEngine.numCheckPlayer1 = 4;
            checkLapEngine.lapPlayer2 = 0;
            checkLapEngine.numCheckPlayer2 = 1;
            bool isActivateTest1 = false;
            bool isActivateTest2 = false;

            //Act
            checkLapEngine.CheckCurrentLap(ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.AreEqual(1, checkLapEngine.lapPlayer1);

        }

        [Test]
        public void ManagerLap_CheckCurrentLap_WhenNumCheckPlayer2GreaterThree()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            checkLapEngine.lapPlayer1 = 0;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.lapPlayer2 = 0;
            checkLapEngine.numCheckPlayer2 = 4;
            bool isActivateTest1 = false;
            bool isActivateTest2 = false;

            //Act
            checkLapEngine.CheckCurrentLap(ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.AreEqual(1, checkLapEngine.lapPlayer2);

        }

        [Test]
        public void ManagerLap_CheckCurrentLap_WhenNumCheckPlayer1LessThree()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            checkLapEngine.lapPlayer1 = 0;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.lapPlayer2 = 0;
            checkLapEngine.numCheckPlayer2 = 4;

            bool isActivateTest1 = false;
            bool isActivateTest2 = false;

            //Act
            checkLapEngine.CheckCurrentLap(ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.AreEqual(0, checkLapEngine.lapPlayer1);

        }

        [Test]
        public void ManagerLap_CheckCurrentLap_WhenNumCheckPlayer2LessThree()
        {
            //Arrange
            ManagerLap checkLapEngine = new ManagerLap();
            checkLapEngine.lapPlayer1 = 0;
            checkLapEngine.numCheckPlayer1 = 1;
            checkLapEngine.lapPlayer2 = 0;
            checkLapEngine.numCheckPlayer2 = 1;
            bool isActivateTest1 = false;
            bool isActivateTest2 = false;

            //Act
            checkLapEngine.CheckCurrentLap(ref isActivateTest1,
                ref isActivateTest2);

            //Assert
            Assert.AreEqual(0, checkLapEngine.lapPlayer2);

        }
    }
}
