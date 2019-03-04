using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovimientoPropsTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MovimientoPropsTestWhenIsGreaterThanOne()
        {
            // Arrange
            var rotationObjects=new MovimientoPropsEngine();
            rotationObjects._rotation = 1.01f;
            float result;
        

            //Act
            result=rotationObjects.rotationObject();

            //Assert
            Assert.Less(result,1.0f);
        }

        [Test]
        public void MovimientoPropsTestWhenIsLessOrEqualZero()
        {
            // Arrange
            var rotationObjects = new MovimientoPropsEngine();
            rotationObjects._rotation = 0.0f;
            float result;


            //Act
            result = rotationObjects.rotationObject();

            //Assert
            Assert.Greater(result,0.0f);
        }

    }
}
