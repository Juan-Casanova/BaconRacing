using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class ControlCerditoTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ControlCerditoTestAceleration()
        {
          //Arrange
          var controlCerditoEngine=new ControlCerditoEngine();


              controlCerditoEngine.coefAceleration = 10.0f;
              controlCerditoEngine.time = 3.2f;
              controlCerditoEngine.brake = 10000;
              controlCerditoEngine.buttonAxisVertical = 12.6f;
              controlCerditoEngine.torqueEngine = 1750.0f;


              //Act
              controlCerditoEngine.aceleration();

              //Arrange
              Assert.Greater(controlCerditoEngine.frontRightMotor,0);

        }

       
        [Test]
        public void ControlCerditoTestReverse()
        {
            //Arrange
            var controlCerditoEngine = new ControlCerditoEngine();


            controlCerditoEngine.coefAceleration = 10.0f;
            controlCerditoEngine.time = 3.2f;
            controlCerditoEngine.brake = 10000;
            controlCerditoEngine.buttonAxisVertical = -12.6f;
            controlCerditoEngine.torqueEngine = 1750.0f;


            //Act
            controlCerditoEngine.reverse();

            //Arrange
            Assert.Less(controlCerditoEngine.frontRightMotor, 0);

        }

        [Test]
        public void ControlCerditoTestDeceleration()
        {
            //Arrange
            var controlCerditoEngine = new ControlCerditoEngine();


            controlCerditoEngine.coefAceleration = 10.0f;
            controlCerditoEngine.time = 3.2f;
            controlCerditoEngine.brake = 10000;
            controlCerditoEngine.buttonAxisVertical = 12.6f;
            controlCerditoEngine.torqueEngine = 1750.0f;


            //Act
            controlCerditoEngine.deceleration();

            //Arrange
            Assert.AreEqual(controlCerditoEngine.frontRightMotor, 320000);

        }


        [Test]
        public void ControlCerditoTestTurn()
        {
            //Arrange
            var controlCerditoEngine = new ControlCerditoEngine();

            controlCerditoEngine.buttonAxisHorizontal = 12.6f;
            controlCerditoEngine.wheelAngleMax = 5.0f;
  


            //Act
            controlCerditoEngine.turn();

            //Arrange
            Assert.Greater(controlCerditoEngine.frontLeftHorizontal, 0);

        }

    }
}
