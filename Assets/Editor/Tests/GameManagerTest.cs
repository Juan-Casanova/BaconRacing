using NUnit.Framework;
using NSubstitute;


namespace Tests
{
    public class GameManagerTest
    {
        [Test]
        public void CompareGameObjectsAreEqual()
        {
            GameManagerEngine _gameManager = new GameManagerEngine();
            int Instance1 = 0, Instance2=0;

            //_gameManager.TEST_Assert_Method(Instance1, Instance2);
            
            

            
            Assert.AreEqual(Instance1, Instance2);
        }
        
    }
}
