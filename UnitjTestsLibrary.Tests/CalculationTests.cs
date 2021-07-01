using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using UnitTestsLibrary;

namespace UnitjTestsLibrary.Tests
{
    public class CalculationTests
    {
        [Theory]
        [InlineData(4,2,6)]
        public void AddShouldReturnExpected(double x, double y, double expected)
        {
            // Arrange
            Calculations cal = new Calculations();
            // Act
            double actual = cal.Add(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SomethingShouldBeDone()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
