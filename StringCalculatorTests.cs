using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace tdd_approach
{
    public class StringCalculatorTests
    {
        
        [Fact]
        public void ShouldReturn_Zero_OfNumbers_In_A_EmptyString()
        {
            var calc = new StringCalculator();
            var result = calc.Add("");
            Assert.Equal(0, result);

        }

        [Fact]
        public void ShouldReturn_1_When_Receive_1_In_a_String()
        {
            var calc = new StringCalculator();
            var result = calc.Add("1");
            Assert.Equal(1,result);
        }

        [Fact]
        public void ShouldReturn_3_When_Sum_1_and_2()
        {
            var calc= new StringCalculator();
            var result = calc.Add("1,2");
            Assert.Equal(3,result);
        }

        [Fact]
        public void ShouldReturn_6_When_Sum_1_2_and_3()
        {
            var calc = new StringCalculator();
            var result = calc.Add("1,2,3");
            Assert.Equal(6, result);
        }

        [Fact]
        public void ShouldReturn_20_When_Sum_10_and_10()
        {
            var calc = new StringCalculator();
            var result = calc.Add("10,10");
            Assert.Equal(20, result);
        }

        [Fact]
        public void ShouldReturn_6_When_Sum_1_2_and_6_Using_BreakLine()
        {
            var calc = new StringCalculator();
            var result = calc.Add("1\n2,3");
            Assert.Equal(6, result);
        }

        [Fact]
        public void ShouldReturn_10_When_Sum_5_and_5_With_Semicolon()
        {
            var calc = new StringCalculator();
            var result = calc.Add("5;5");
            Assert.Equal(10,result);
        }

        [Fact]
        public void ShouldReturn_10_When_Sum_5_and_5_With_CustomDelimiter()
        {
            var calc = new StringCalculator();
            var result = calc.Add("//;\n5;5");
            Assert.Equal(10,result);
        }

        [Fact]
        public void ShouldReturn_Exception_When_Have_A_Negative_Number()
        {
            var calc = new StringCalculator();
            Assert.Throws<Exception>(() => calc.Add("-2,5") );
        }
        
        
        [Fact]
        public void ShouldReturn_Exception_When_Have_Negative_Numbers_and_Show_Them()
        {
            var calc = new StringCalculator();
            var ex = Assert.Throws<Exception>(() => calc.Add("-2,-3,5") );
            Assert.Equal("Negatives not allowed: -2, -3", ex.Message);
        }

         [Fact]
        public void ShouldReturn_10_When_Sum_5_and_5_withLetters()
        {
            var calc = new StringCalculator();
            Assert.Throws<Exception>(() => calc.Add("5A, 5B") );
            
        }
        
        
        

        //IntMax + IntMax

    }
}