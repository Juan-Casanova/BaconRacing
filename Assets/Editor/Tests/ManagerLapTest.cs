using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ManagerLapTest
    {
        
        [Test]
        public void ManagerLapTestSimplePasses_1()
        {
            ManagerLap _managerLap = new ManagerLap();

            bool isActivate1 = false;
            bool isActivate2 = false;
            _managerLap.ManageCheckLap(false, ref isActivate1, ref isActivate2);
            
        }

        [Test]
        public void ManagerLapTestSimplePasses()
        {
            ManagerLap _managerLap = new ManagerLap();

            bool isActivate1 = false;
            bool isActivate2 = false;
            _managerLap.ManageCheckLap(true, ref isActivate1, ref isActivate2);

        }

        [Test]
        public void ManagerLapTestSimplePasses_allFalse()
        {
            ManagerLap _managerLap = new ManagerLap();

            bool isActivate1 = true;
            bool isActivate2 = false;
            _managerLap.ManageCheckLap(false, ref isActivate1, ref isActivate2);

        }

        [Test]
        public void Check_currentPlayer1_lap_all_False()
        {
            ManagerLap _managerLap = new ManagerLap();

            _managerLap.numCheckPlayer1 = 4;
            bool isActivate1 = false;
            bool isActivate2 = false;

            _managerLap.CheckCurrentLap(ref isActivate1, ref isActivate2);
        }

        [Test]
        public void Check_current_lapPlayer2_all_False()
        {
            ManagerLap _managerLap = new ManagerLap();

            _managerLap.numCheckPlayer2 = 4;
            bool isActivate1 = false;
            bool isActivate2 = false;

            _managerLap.CheckCurrentLap(ref isActivate1, ref isActivate2);
        }



    }
}
