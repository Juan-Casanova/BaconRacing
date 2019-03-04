using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class RespawnPlayerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void RespawnPlayerTestWhenIsZero()
        {
            //Arrange
            var respawnPlayerTest=new RespawnPlayerEngine();
            respawnPlayerTest.numSpawn = 0;
            //Act
            respawnPlayerTest.numSpawn = respawnPlayerTest.IncreaseNumSpawn();

            //Assert
            Assert.AreEqual(respawnPlayerTest.numSpawn,1);
        }

        [Test]
        public void RespawnPlayerTestWhenIsMajorThanSix()
        {
            //Arrange
            var respawnPlayerTest = new RespawnPlayerEngine();
            respawnPlayerTest.numSpawn = 7;
            //Act
            respawnPlayerTest.numSpawn = respawnPlayerTest.IncreaseNumSpawn();

            //Assert
            Assert.AreEqual(respawnPlayerTest.numSpawn, 0);
        }


    }
}
