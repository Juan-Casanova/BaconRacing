using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ItemControlTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ItemControl_ChargeItem_PoderItem1IsActivate()
        {
            //Arrange
            var sustitute=new ItemControlSustitute();
            ItemControlEngine itemControlEngine=new ItemControlEngine();
            int numRandom=1;

            //Act
            itemControlEngine.ChargeItem(numRandom, sustitute);

            //Assert
            Assert.IsTrue(sustitute.poder1IsActive);

        }

        [Test]
        public void ItemControl_ChargeItem_PoderItem2IsActivate()
        {
            //Arrange
            var sustitute = new ItemControlSustitute();
            ItemControlEngine itemControlEngine = new ItemControlEngine();
            int numRandom = 2;

            //Act
            itemControlEngine.ChargeItem(numRandom,sustitute);

            //Assert
            Assert.IsTrue(sustitute.poder2IsActive);

        }

        [Test]
        public void ItemControl_ChargeItem_PoderItem3IsActivate()
        {
            //Arrange
            var sustitute = new ItemControlSustitute();
            ItemControlEngine itemControlEngine = new ItemControlEngine();
            int numRandom = 3;

            //Act
            itemControlEngine.ChargeItem(numRandom, sustitute);

            //Assert
            Assert.IsTrue(sustitute.poder3IsActive);

        }

    }
}


public class ItemControlSustitute : IItemControl
{
    public bool poder1IsActive = false;
    public bool poder2IsActive = false;
    public bool poder3IsActive = false;

    public void PoderItem1()
    {
        poder1IsActive = true;
    }

    public void PoderItem2()
    {
        poder2IsActive = true;
    }

    public void PoderItem3()
    {
        poder3IsActive = true;
    }
}