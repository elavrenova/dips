using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dips_lab1.Controllers;

namespace test_dips_lab1
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestEmptyName()
        {
            var contr = new ValuesController();
            Assert.AreEqual(contr.GetString(5,null),"Somebody has 5 cats");
            var test = contr.Method();
            
        }

        public void TestZeroQuantityEmptyName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(0, null), "Somebody doesn't have any cats");
        }

        public void TestQuantityEmptyName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(2, null), "Somebody has 2 cats");
        }
        public void TestQuantityName()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.GetString(3, "Mary"), "Mary has 3 cats");
        }
    }
}
