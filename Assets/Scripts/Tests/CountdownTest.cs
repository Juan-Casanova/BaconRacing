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
        [UnityTest]
        public void CountdownTestSimplePasses()
        {
            //Arrange
            var countDown = new GameObject().AddComponent<Countdown>();
            float time = 1.0f;
            float initialCounter=1.0f;
          
            bool activateMovement=false;
            
            //Act
            countDown.activateMovement(initialCounter,time, activateMovement);

            //Assert
            Assert.IsTrue(activateMovement);

        }

       
    }
}
