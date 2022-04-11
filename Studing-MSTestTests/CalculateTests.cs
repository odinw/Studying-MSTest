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
        // basic sample
        [TestMethod()]
        public void Add()
        {
            // arrage
            var expected = 3;
            var calculate = new Calculate();

            // act
            var result = calculate.Add(1, 2);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [DataRow(1, 2, 3)]
        [DataRow(30, 70, 100)]
        public void Add_ParameterByDataRow(int value1, int value2, int expected)
        {
            // arrage
            var calculate = new Calculate();

            // act
            var result = calculate.Add(value1, value2);

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}