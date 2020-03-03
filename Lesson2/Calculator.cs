using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Calculator
    {
        InputValidations inputValidator = new InputValidations();
        MathOperations mathOperations = new MathOperations();
        public void MultiplyNumbersEnteredByUser()
        {
            Console.WriteLine("I wanna calculate something for you, please input the first digit");
            var firstDigit = Console.ReadLine();

            Console.WriteLine("Please, enter second digit");
            var secondDigit = Console.ReadLine();

            inputValidator.VerifyInputForLetters(firstDigit);
            inputValidator.VerifyInputForLetters(secondDigit);

            mathOperations.Multiply(firstDigit, secondDigit);
        }

          
    }
}