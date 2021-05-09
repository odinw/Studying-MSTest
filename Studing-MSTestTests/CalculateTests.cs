using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studing_MSTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studing_MSTest.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void Add()
        {
            Calculate calculate = new Calculate();
            var sum = calculate.Add(1, 2);
            Assert.AreEqual(sum, 3);
        }

        [TestMethod()]
        [DataRow(1, 2, 3)]
        public void Add_ParameterByDataRow(int v1, int v2, int result)
        {
            Calculate calculate = new Calculate();
            var sum = calculate.Add(v1, v2);
            Assert.AreEqual(sum, result);
        }
    }
}