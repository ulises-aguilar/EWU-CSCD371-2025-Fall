using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;


namespace Assignment.Tests
{
    [TestClass]
    public class SampleDataTests
    {
        [TestMethod]
        public void CsvRows_ReturnCorrectNumberOfRows_Successfully()
        {
            // Arrange
            SampleData sampleData = new SampleData();

            // Act
            var firstRow = sampleData.CsvRows.First();
            var column = firstRow.Split(',');

            // Assert
            Assert.AreEqual<int>(8, column.Count());
        }
    }
}