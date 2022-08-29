using MathematicsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAPI.Tests.Unit
{
    public class CalclulateRepoTests 
    {
        private readonly CalclulateRepo _sut = new();

        [Theory]
        //Verify the addition of two integers
        [InlineData(4,3,7)]
        //Verify the addition of one positive and one negative number(integers)
        [InlineData(6,-6,0)]
        //Verify the addition of two negative numbers (integers)
        [InlineData(-10, -7, -17)]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        { 
            //Act
            var result = _sut.Add(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        //Verify the subtraction of two integers
        [InlineData(8,2,6)]
        //Verify the subtraction of one negative and one positive number (integers)
        [InlineData(-12, 14,-26)]
        //Verify the subtraction of two negative numbers (integers)
        [InlineData(-7,-8, 1)]
        public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Substract(a, b);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        //Verify the multiplication of two integers
        [InlineData(7, 3, 21)]
        //Verify the multiplication of one negative and one positive number (integers)
        [InlineData(-10, 2, -20)]
        //Verify the multiplication of two negative numbers (integers)
        [InlineData(-5, -3, 15)]
        public void Multiply_ShouldMultiplyTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Multiply(a, b);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        //Verify the division of two integers
        [InlineData(4, 4, 1)]
        //Verify the division of one negative and one positive number (integers)
        [InlineData(-8, 2, -4)]
        //Verify the division of two negative numbers (integers)
        [InlineData(-9, -3, 3)]
        //Verify the division of a number (integer) by zero
        [InlineData(5,0,0)]
        public void Divide_ShouldDivideTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Divide(a, b);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}
