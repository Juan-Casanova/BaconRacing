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
          //  itemControl.ChargeItem(numRandom);

            //Assert
            Assert.Greater(numRandom,0);
        }

        [Test]
        public void InstantiateBaconInSamePositionPlayerItem1()
        {
            //Arrange
            var player = GameObject.FindGameObjectWithTag("Player");
            var itemControl = new GameObject().AddComponent<ItemControl>();
            GameObject testTocino;
           

            //Act
            itemControl.PoderItem1();

            //Assert

        }

    }
}
