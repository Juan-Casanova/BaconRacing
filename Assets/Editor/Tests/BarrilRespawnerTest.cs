using NSubstitute;
using NUnit.Framework;

namespace  Tests
{
    
    public class BarrilRespawnerTest
    {
        [Test]
        public void ComprobarRotacionIgualMenorQue6()
        {
            //Arrange
            BarrilRespwnEngine _barrilRespwnEngine = new BarrilRespwnEngine();
            BarrilRespwnEngine.Rotacion = 6;
            float result;
            
            //Act
            result = _barrilRespwnEngine.Rotacion_Ida_Vuelta();
            
            //Assert
            Assert.AreEqual(result, 6.25f);
        }
        
        [Test]
        public void ComprobarRotacionMayorQue6()
        {
            //Arrange
            BarrilRespwnEngine _barrilRespwnEngine = new BarrilRespwnEngine();
            BarrilRespwnEngine.Rotacion = 7;
            float result;
            
            //Act
            result = _barrilRespwnEngine.Rotacion_Ida_Vuelta();
            
            //Assert
            Assert.AreEqual(result, 6.75f);
        }
        
        
        
                  
    }

}