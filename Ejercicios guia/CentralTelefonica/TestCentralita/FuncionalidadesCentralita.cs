using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Centralita;

namespace TestCentralita
{
    [TestClass]
    public class FuncionalidadesCentralita
    {
        [TestMethod]
        public void ListaDeLlamadasInicializada()
        {
            //Arrange y Act
            Centralita.Centralita c = new Centralita.Centralita();
            //Assert
            Assert.IsNotNull(c.Llamadas);
        }
        [ExpectedException(typeof(CentralitaException))]
        [TestMethod]
        public void ExcepcionLlamadasLocalesIguales() 
        {
            //Arrange
            Local l1 = new Local("123", 4, "456", 5);
            Local l2 = new Local("123", 4, "456", 5);
            Centralita.Centralita c = new Centralita.Centralita();
            //Act y Assert
            c += l1;
            c += l2;

        }
        [ExpectedException(typeof(CentralitaException))]
        [TestMethod]
        public void ExcepcionLlamadasProvincialesIguales() 
        {
            //Arrange
            Provincial l1 = new Provincial("123",Provincial.Franja.Franja_1,5,"456");
            Provincial l2 = new Provincial("123", Provincial.Franja.Franja_1, 5, "456");
            Centralita.Centralita c = new Centralita.Centralita();
            //Act y Assert
            c += l1;
            c += l2;
        }
        [TestMethod]
        public void ComparacionLlamadasIguales() 
        {
            //Arrange
            Local local1 = new Local("123", 5, "456", 5);
            Local local2 = new Local("123", 5, "456", 5);
            Provincial provincial1 = new Provincial("123", Provincial.Franja.Franja_1, 5, "456");
            Provincial provincial2 = new Provincial("123", Provincial.Franja.Franja_1, 5, "456");
            Centralita.Centralita c = new Centralita.Centralita();
            //Act y Assert
            c += local1;
            c += provincial1;
            try 
            {
                c += local2;   
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
            try 
            {
                c += provincial2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }

        }
    }
}
