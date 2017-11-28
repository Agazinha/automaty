using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class Mathematics_test
    {
        [Fact]
        public void Method_add_returns_sum_of_given_values()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Add(10, 20);

            // assert
            Assert.Equal(30, result);
        }

        [Fact]
    public void Method_add_returns_sum_of_given_values_2()
    {
        // arrange
        var math = new Mathematics();

        // act
        double result = math.Add(-10, 20);

        // assert
        Assert.Equal(10, result);
        }

        [Fact]
        public void Method_add_returns_sub_of_given_values()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Substract(-10, 20);

            // assert
            Assert.Equal(-30, result);
        }

        [Fact]
        public void Method_add_returns_sub_of_given_values_2()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Substract(78, 2);

            // assert
            Assert.Equal(76, result);
        }

        [Fact]
        public void Method_add_returns_dev_of_given_values()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Devide(4, 4);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Method_add_returns_dev_of_given_values_2()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Devide(10, 5);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Method_add_returns_mult_of_given_values()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Multiply(10, 5);

            // assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Method_add_returns_mult_of_given_values_2()
        {
            // arrange
            var math = new Mathematics();

            // act
            double result = math.Multiply(5, 5);

            // assert
            Assert.Equal(25, result);
        }

    }

}
