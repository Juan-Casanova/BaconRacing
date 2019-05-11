using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using NSubstitute;


namespace Tests
{
    public class GameManagerTest
    {
        [Test]
        public void CompareGameObjectsAreEqual()
        {
            PlayerPrefab1 _gameManager = new PlayerPrefab1();


            
            GameObject someobject = null;
            GameObject otherobject = null;
            _gameManager.TEST_Assert_Method(ref someobject, ref otherobject);

            
            Assert.AreEqual(someobject, otherobject);
        }
        
    }
}
