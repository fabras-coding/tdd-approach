using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_approach
{
    public class FizzBuzz
    {
        
        public string Generate(int number)
        {
            
            if(number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if(number % 3 == 0)
                return "Fizz";

            if(number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }

    }
}