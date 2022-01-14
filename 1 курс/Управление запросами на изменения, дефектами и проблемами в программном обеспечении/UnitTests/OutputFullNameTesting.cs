using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BL;

namespace UnitTests
{
    [TestClass]
    public class OutputFullNameTesting
    {
        [TestMethod]
        public void OutputFullNameTest()
        {
            Employee employee = new Employee("Зайцева", "Евгения", "Артёмовна");
            Assert.AreEqual("Зайцева Е.А.", employee.OutputFullName());
        }
    }
}