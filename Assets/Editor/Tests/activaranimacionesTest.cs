﻿using NSubstitute;
using NUnit.Framework;

namespace Tests
{

    public class activaranimacionesTest
    {
        
        [Test]

        public void When_Numero_Animacion_is_Zero()
        {
            //Arrange
            ActivaranimacionesEngine activaranimacionesEngine = new ActivaranimacionesEngine();
            
            activaranimacionesEngine.numeroAnimacion = 0;
            int result;
            
            //Act
            result = activaranimacionesEngine.SeleccionAnimacionforTest();
            
            //Assert
            Assert.AreEqual(result, 0);
        }
        
        [Test]

        public void When_Numero_Animacion_is_Three()
        {
            //Arrange
            ActivaranimacionesEngine activaranimacionesEngine = new ActivaranimacionesEngine();
            
            activaranimacionesEngine.numeroAnimacion = 3;
            int result;
            
            //Act
            result = activaranimacionesEngine.SeleccionAnimacionforTest();
            
            //Assert
            Assert.AreEqual(result, 3);
        }
        
        [Test]

        public void When_Numero_Animacion_is_One()
        {
            //Arrange
            ActivaranimacionesEngine activaranimacionesEngine = new ActivaranimacionesEngine();
            
            activaranimacionesEngine.numeroAnimacion = 1;
            int result;
            
            //Act
            result = activaranimacionesEngine.SeleccionAnimacionforTest();
            
            //Assert
            Assert.AreEqual(result, 1);
        }
        
        [Test]

        public void When_Numero_InputAnimacion_is_Zero()
        {
            //Arrange
            ActivaranimacionesEngine activaranimacionesEngine = new ActivaranimacionesEngine();
            
            activaranimacionesEngine.numeroAnimacion = 0;
            int result;
            
            //Act
            result = activaranimacionesEngine.SeleccionAnimacion();
            
            //Assert
            Assert.AreEqual(result, 0);
        }
            
   
    }
    
    
    
    
    
}