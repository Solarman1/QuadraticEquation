using Xunit;
using QuadraticEquation;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //equationModel inputValue;

        [Fact]
        public void Test1()
        {
            ////Arrange
            Solution equation = new Solution();

            ////Act
            string result = equation.Equation(1, 0, 1);
            //inputValue = new equationModel(1,0,1);
            

            ////Assert
            Assert.Equal("equation not have solution", result);
        }
        [Fact]
        public void Test2()
        {
            ////Arrange
            Solution equation = new Solution();

            ////Act
            string result = equation.Equation(2, 5, -3.5);
           

            ////Assert
            Assert.Equal("53, -3,0700274723201293, 0,5700274723201295", result);
        }
        [Fact]
        public void Test3()
        {
            ////Arrange
            Solution equation = new Solution();

            ////Act
            string result = equation.Equation(1, 1, 1);


            ////Assert
            Assert.Equal("equation not have solution", result);
        }
        [Fact]
        public void Test4()
        {
            ////Arrange
            Solution equation = new Solution();

            ////Act
            string result = equation.Equation(1, 4, 1);


            ////Assert
            Assert.Equal("12, -3,732050807568877, -0,2679491924311228", result);
        }
    }
}
