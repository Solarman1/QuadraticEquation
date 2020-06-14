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
            Solution equation = new Solution(1, 0, 1);

            ////Act
            string result = equation.get_Equation;
            //inputValue = new equationModel(1,0,1);
            

            ////Assert
            Assert.Equal("equation not have solution", result);
        }
        [Fact]
        public void Test2()
        {
            ////Arrange
            Solution equation = new Solution(2, 5, -3.5);

            ////Act
            string result = equation.get_Equation;
           

            ////Assert
            Assert.Equal("53, -3,0700274723201293, 0,5700274723201295", result);
        }
        [Fact]
        public void Test3()
        {
            ////Arrange
            Solution equation = new Solution(1, 1, 1);

            ////Act
            string result = equation.get_Equation;


            ////Assert
            Assert.Equal("equation not have solution", result);
        }
        [Fact]
        public void Test4()
        {
            ////Arrange
            Solution equation = new Solution(1, 4, 1);

            ////Act
            string result = equation.get_Equation;


            ////Assert
            Assert.Equal("12, -3,732050807568877, -0,2679491924311228", result);
        }

        //[Fact]
        //public void Test5()
        //{
        //    //Arrange
        //    Solution equation = new Solution();

        //    //Act
        //    double testingA = Convert.ToDouble(Console.ReadLine());
        //    double testingB = Convert.ToDouble(Console.ReadLine());
        //    double testingC = Convert.ToDouble(Console.ReadLine());


        //    //Assert
        //    Assert.True(true,equation.Equation(testingA,testingB,testingC));
        //}
    }
}
