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
            Manager manager = new Manager("Зайцева", "Евгения", "Артёмовна", 5);
            NUnit.Framework.Assert.AreEqual(32500, manager.PayrollToManager());
        }
    }
}