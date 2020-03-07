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
            inputValidator.VerifyInputForLetters(firstDigit);

            Console.WriteLine("Please, enter second digit");
            var secondDigit = Console.ReadLine();
            inputValidator.VerifyInputForLetters(secondDigit);

            mathOperations.Multiply(firstDigit, secondDigit);
        }

    public void CalculateSpeed()
        {
            Console.WriteLine("Input distance(meters): ");
            string distance = Console.ReadLine();

            Console.WriteLine("Input timeSec(hour): ");
            string hours = Console.ReadLine();

            Console.WriteLine("Input timeSec(minutes): ");
            string minutes = Console.ReadLine();

            Console.WriteLine("Input timeSec(seconds):  ");
            string seconds = Console.ReadLine();


            mathOperations.ShowDistanceAsKilometersPerHours(distance, hours, minutes, seconds);
            mathOperations.ShowDistanceAsKilometersPerMiles(distance, hours, minutes, seconds);
           // mathOperations.ShowDistanceAsMetersPerSeconds(distance, hours, minutes, seconds);







        }


    }
}