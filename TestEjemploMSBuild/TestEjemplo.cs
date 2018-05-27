using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploMSBuild;

namespace TestEjemploMSBuild
{
    [TestClass]
    public class TestEjemplo
    {
        [TestMethod]
        public void TestIgual()
        {
            int x = 1;
            int y = 1;

            Ejemplo aux = new Ejemplo(x, y);
            bool comprobar = aux.metodo(x, y);
            Assert.IsTrue(comprobar);

        }
        [TestMethod]
        public void TestNoIgual()
        {
            int x = 1;
            int y = 2;

            Ejemplo aux = new Ejemplo(x, y);
            bool comprobar = aux.metodo(x, y);
            Assert.IsTrue(comprobar);

        }
    }
}
