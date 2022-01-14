using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using BL;

namespace UnitTests
{
    [TestClass]
    public class PayrollToManagerTesting
    {
        [TestMethod]
        public void PayrollToManagerTest()
        {
            Manager manager = new Manager("Зайцева", "Евгения", "Артёмовна", 0);
            NUnit.Framework.Assert.AreEqual(25000, manager.PayrollToManager());
        }
    }
}
