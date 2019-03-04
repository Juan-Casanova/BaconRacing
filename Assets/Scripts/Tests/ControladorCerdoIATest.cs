using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ControladorCerdoIATest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ControladorCerdoIATestEnterMethodMove()
        {
            // Arrange
            var controlCerditoIA=new ControladorCerditoIAEngine();
            controlCerditoIA.distance=10.0f;
            controlCerditoIA.minDistance = 5.0f;
            controlCerditoIA.rand = true;
            controlCerditoIA.go = true;
            controlCerditoIA.countDownEngine = true;
            controlCerditoIA.activeMethodMove = false;
            controlCerditoIA.numRandom = 5;
            controlCerditoIA.num = 3;
            controlCerditoIA.waypoints = 138;

            //Act
            controlCerditoIA.controlCerditoIAEngine();

            //Arrange
            Assert.IsTrue(controlCerditoIA.activeMethodMove);

            
        }

        [Test]
        public void ControladorCerdoIATestRandIsFalseAndNumPlusOneIsTheSameWaypoints()
        {
            // Arrange
            var controlCerditoIA = new ControladorCerditoIAEngine();
            controlCerditoIA.distance = 4.0f;
            controlCerditoIA.minDistance = 5.0f;
            controlCerditoIA.rand = false;
            controlCerditoIA.go = true;
            controlCerditoIA.countDownEngine = true;
            controlCerditoIA.activeMethodMove = false;
            controlCerditoIA.numRandom = 5;
            controlCerditoIA.num = 137;
            controlCerditoIA.waypoints = 138;

            //Act
            controlCerditoIA.controlCerditoIAEngine();

            //Arrange
            Assert.AreEqual(controlCerditoIA.num,0);

        }

        [Test]
        public void ControladorCerdoIATestRandIsFalseAndNumPlusOneIsDiferentWaypoints()
        {
            // Arrange
            var controlCerditoIA = new ControladorCerditoIAEngine();
            controlCerditoIA.distance = 4.0f;
            controlCerditoIA.minDistance = 5.0f;
            controlCerditoIA.rand = false;
            controlCerditoIA.go = true;
            controlCerditoIA.countDownEngine = true;
            controlCerditoIA.activeMethodMove = false;
            controlCerditoIA.numRandom = 5;
            controlCerditoIA.num = 117;
            controlCerditoIA.waypoints = 138;

            //Act
            controlCerditoIA.controlCerditoIAEngine();

            //Arrange
            Assert.AreEqual(controlCerditoIA.num, 118);

        }

        [Test]
        public void ControladorCerdoIATestRandIsTrue()
        {
            // Arrange
            var controlCerditoIA = new ControladorCerditoIAEngine();
            controlCerditoIA.distance = 4.0f;
            controlCerditoIA.minDistance = 5.0f;
            controlCerditoIA.rand = true;
            controlCerditoIA.go = true;
            controlCerditoIA.countDownEngine = true;
            controlCerditoIA.activeMethodMove = false;
            controlCerditoIA.numRandom = 5;
            controlCerditoIA.num = 117;
            controlCerditoIA.waypoints = 138;

            //Act
            controlCerditoIA.controlCerditoIAEngine();

            //Arrange
            Assert.AreEqual(controlCerditoIA.num, controlCerditoIA.numRandom);

        }

    }
}
