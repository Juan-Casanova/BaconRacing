using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BarrilResoawnTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public IEnumerator BarrilResoawnTestSimplePasses()
        {
            //Arrange
            var barril=new GameObject().AddComponent<BarrilRespawn>();
            Vector3 barril1;
            Vector3 barril2;


            //Act
            barril2 = barril.transform.position;
            barril.DisapearBarrilForSeconds();
            barril1 = barril.transform.position;

            yield return null;
          
            //Assert
            Assert.AreEqual(barril1,barril2);

        }

      
       
    }
}
