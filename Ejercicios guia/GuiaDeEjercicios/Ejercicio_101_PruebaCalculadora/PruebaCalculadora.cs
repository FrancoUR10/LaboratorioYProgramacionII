using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_101_TestDrivenDevelopment;

namespace Ejercicio_101_PruebaCalculadora
{
    [TestClass]
    public class PruebaCalculadora
    {
        [TestMethod]
        public void NumerosValidos()
        {
            //Arrange
            string numeros = "52,7";
            //Act
            int resultado=Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(59, resultado);
        }
        [TestMethod]
        public void NumerosConLetras()
        {
            //Arrange
            string numeros = "g5h2,7";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(59, resultado);
        }
        [TestMethod]
        public void NumeroVacio()
        {
            //Arrange
            string numeros = "";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void SoloUnNumero()
        {
            //Arrange
            string numeros = "23";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(23, resultado);
        }
        [TestMethod]
        public void SoloNumeroIzquierda()
        {
            //Arrange
            string numeros = "23,";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(23, resultado);
        }
        [TestMethod]
        public void SoloNumeroDerecha()
        {
            //Arrange
            string numeros = ",57";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(57, resultado);
        }
        [TestMethod]
        public void SoloComa()
        {
            //Arrange
            string numeros = ",";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void NumeroConSaltoDeLinea()
        {
            //Arrange
            string numeros = "1 \n 2,3";
            //Act
            int resultado = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(15, resultado);
        }
    }
}
