using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TakeOut_titleTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TakeOut_titleTestWhenPressAnyButton()
        {
           //Arrange
           var takeOut_title=new TakeOut_titleEngine();
           bool mainCanvasIsActive, characterCanvasIsActive, pressAnyKey;
           pressAnyKey = takeOut_title.pressAnyKey = true;

            //Act
            takeOut_title.pressAnyKeyForShowCnavas();

            //Assert
            Assert.IsFalse(takeOut_title.mainCanvasIsActive);

        }

        [Test]
        public void TakeOut_titleTestWhenNotPressAnyButton()
        {
            //Arrange
            var takeOut_title = new TakeOut_titleEngine();
            bool mainCanvasIsActive, characterCanvasIsActive, pressAnyKey;
            pressAnyKey = takeOut_title.pressAnyKey = false;

            //Act
            takeOut_title.pressAnyKeyForShowCnavas();

            //Assert
            Assert.IsTrue(takeOut_title.mainCanvasIsActive);

        }


    }
}
