using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_approach
{
    public class StringCalculator
    {
        
        public int Add(string numbers)
        {
            int result = 0;
            if(string.IsNullOrEmpty(numbers))
                return result;

            
            
            var sNumbers = Utils.DetectAndRemoveTokens(numbers).Split(',');
            List<int> negatives = new List<int>();                        
            
            for(int i=0; i < sNumbers.Length; i++)
            {
                string number = sNumbers[i];
                foreach(var c in number)
                {
                    if(!(c >= '0') && !(c <= '9'))
                        number = "0";
                }

                int sumNumber = number != "" ? Int16.Parse(number) : 0;

                if(sumNumber < 0)
                    negatives.Add(sumNumber);

                result += sumNumber;
            }

            if(negatives.Count > 0)
                    throw new Exception($"Negatives not allowed: {string.Join(", ",negatives)}");

            return result;
        }
        
    }

    public static class Utils
    {
        public static string DetectAndRemoveTokens(string numbers)
        {
           
           if(numbers.StartsWith("//"))
            {
                numbers = numbers.Replace("//", "");
            }

            numbers = numbers.Replace("\n", ",");
            numbers = numbers.Replace(";",",");

            return numbers;
        }
    }

}