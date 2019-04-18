
using NUnit.Framework;

namespace Tests
{
    public class CheckTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CheckTest_CheckCurrentCheckpoint_IfCurrentCheckpointIsLessThanNumCheckpoints()
        {
           //Arrange
           CheckEngine checkEngine = new CheckEngine();
            checkEngine.currentCheckpoint = 3;
            checkEngine.lenghtSpawn = 6; 
            checkEngine.currentLap =0;

           //Act
           checkEngine.CheckCurrentCheckpoint();

            //Assert
            Assert.AreEqual(4, checkEngine.currentCheckpoint);
        }

        // A Test behaves as an ordinary method
        [Test]
        public void CheckTest_CheckCurrentCheckpoint_IfCurrentCheckpointIsGreaterThanNumCheckpoints()
        {
            //Arrange
            CheckEngine checkEngine = new CheckEngine();
            checkEngine.currentCheckpoint = 7;
            checkEngine.lenghtSpawn = 6;
            checkEngine.currentLap = 0;

            //Act
            checkEngine.CheckCurrentCheckpoint();

            //Assert
            Assert.AreEqual(1, checkEngine.currentLap);
            Assert.AreEqual(0, checkEngine.currentCheckpoint);
        }


    }
}
