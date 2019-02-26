using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ItemTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ItemTestSimplePasses()
        {

            //Arrange
            var itemControl = new GameObject().AddComponent<ItemControl>();
            int numRandom = 0;

            //Act
            itemControl.ChargeItem(numRandom);

            //Assert
            Assert.Greater(numRandom,0);
        }

    }
}
