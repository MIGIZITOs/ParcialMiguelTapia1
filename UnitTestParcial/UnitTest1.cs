using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialMiguelTapia1.Controllers;

namespace UnitTestParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {   //ARRANGE
            CountriesController controller = new CountriesController();
            //ACT
            var lista = controller.GetCountries();
            //assert
            Assert.IsNotNull(lista);
        }
    }
}
