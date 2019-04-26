﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ManagerHUDTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ManagerHUD_ActivateHUD_MovementIsDesactive()
        {
            // Arrange
            ManagerHUDEngine managerHudEngine=new ManagerHUDEngine();
            managerHudEngine.isMovementActive = false;
            managerHudEngine.isInstructionsP1Active = true;
            managerHudEngine.isInstructionsP2Active = true;
            managerHudEngine.t_posPlayer1 = "1";
            managerHudEngine.t_posPlayer2 = "2";
            managerHudEngine.t_laps1 = "2";
            managerHudEngine.t_laps2 = "2";
            managerHudEngine.distanceP1 = 10.5f;
            managerHudEngine.distanceP2 = 10.7f;
            managerHudEngine.t_coutndown = "5.6";
            managerHudEngine.initialCounter =4;

            //Act
            managerHudEngine.ActivateHUD();

            //Assert
            Assert.IsTrue(managerHudEngine.isInstructionsP1Active);
        }


        [Test]
        public void ManagerHUD_ActivateHUD_MovementIsActive()
        {
            // Arrange
            ManagerHUDEngine managerHudEngine = new ManagerHUDEngine();
            managerHudEngine.isMovementActive = true;
            managerHudEngine.isInstructionsP1Active = true;
            managerHudEngine.isInstructionsP2Active = true;
            managerHudEngine.t_posPlayer1 = "1";
            managerHudEngine.t_posPlayer2 = "2";
            managerHudEngine.t_laps1 = "2";
            managerHudEngine.t_laps2 = "2";
            managerHudEngine.distanceP1 = 10.5f;
            managerHudEngine.distanceP2 = 10.7f;
            managerHudEngine.t_coutndown = "5.6";
            managerHudEngine.initialCounter = 4;

            //Act
            managerHudEngine.ActivateHUD();

            //Assert
            Assert.IsFalse(managerHudEngine.isInstructionsP1Active);
        }

        [Test]
        public void ManagerHUD_ActivateHUD_TestMethodHideScreen()
        {
            // Arrange
            ManagerHUDEngine managerHudEngine = new ManagerHUDEngine();
           var sustituteHide=new SustituteHideScreens();

            //Act
            managerHudEngine.HideScreens(sustituteHide);

            //Assert
            Assert.IsTrue(sustituteHide.HideScreenswasCalled);
        }

        [Test]
        public void ManagerHUD_CheckWinner_WinnerPlayer1()
        {
            // Arrange
            ManagerHUDEngine managerHudEngine=new ManagerHUDEngine();
            managerHudEngine.lapP1=3;
            managerHudEngine.lapP2 = 2;
            managerHudEngine.winner0 = false;
            managerHudEngine.winner1 = false;
            managerHudEngine.winner2 = false;
            managerHudEngine.winner3 = false;

            //Act
           managerHudEngine.checkWinner();

            //Assert
            Assert.IsTrue(managerHudEngine.winner0);
        }

        [Test]
        public void ManagerHUD_CheckWinner_WinnerPlayer2()
        {
            // Arrange
            ManagerHUDEngine managerHudEngine = new ManagerHUDEngine();
  
            managerHudEngine.lapP1 = 2;
            managerHudEngine.lapP2 = 3;
            managerHudEngine.winner0 = false;
            managerHudEngine.winner1 = false;
            managerHudEngine.winner2 = false;
            managerHudEngine.winner3 = false;

            //Act
            managerHudEngine.checkWinner();

            //Assert
            Assert.IsTrue(managerHudEngine.winner2);
        }
    }
}

public class SustituteHideScreens : IManagerHUD
{
    public bool HideScreenswasCalled = false;

    public void HideScreens()
    {
        HideScreenswasCalled = true;
    }
}
