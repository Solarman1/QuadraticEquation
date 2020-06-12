using System;
using Xunit;

namespace QuadraticEquation
{
    public class QuadraticEquationTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            EquatuinForTest equation = new EquatuinForTest();
            //Act
            var result = equation.Equation(2,5,-3.5);

            //Assert
            Assert.Equal(true, result);
        }
    }
}
