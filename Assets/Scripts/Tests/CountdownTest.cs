using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CountdownTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CountdownTestSimplePasses()
        {
            //Arrange
            var countDown = new GameObject().AddComponent<Countdown>();
            float initialCounter=5.0f;
            float time=0.0f;
            bool activateMovement=false;

            //Act
            countDown.activateMovement(initialCounter, time, activateMovement);

            //Assert
            Assert.IsFalse(activateMovement);

        }

       
    }
}
