using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

namespace Tests
{
    public class MetaTest1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MetaTest1SimplePasses()
        {
            
            string GamerTag = "Player";
            int Checkpoint = 1;

            int Index = 2;
            int currentlap = 0;
            int currentCheckPoint =1;
            //IMeta _Meta;
            var _SubsMeta = Substitute.For<IMeta>();
            _SubsMeta.GameOver(null);
            MetaEngine _MetaEngine = new MetaEngine();

            _MetaEngine.Vueltas( GamerTag, Checkpoint, Index, ref currentlap, ref currentCheckPoint, _SubsMeta, null);

            Assert.AreEqual(1, currentlap);
            Assert.AreEqual(0, currentCheckPoint);
        }

  

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        
        
    }
}
