using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public  class MathOperations
    {
        public void Multiply(string firstDigit, string secondDigit)
        {
            try
            {
                int results = Convert.ToInt16(firstDigit) * Convert.ToInt32(secondDigit);
                Console.WriteLine($"Here you are: {results} :");
            }
            catch (Exception)
            {
                Console.WriteLine("Not valid data");
                return;
            }
        }
    }
}
