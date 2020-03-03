using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Calculator
    {
        public void Multiply()
        {
            Console.WriteLine("I wanna calculate something for you, please input the first digit");
            var firstDigit = Console.ReadLine();
            VerifyInputForLetters(firstDigit);

            Console.WriteLine("Please, enter second digit");
            var secondDigit = Console.ReadLine();
            VerifyInputForLetters(secondDigit);

            Multiply(firstDigit, secondDigit);
        }

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
        private void VerifyInputIsValid(int inputFromUser)
        {
            if (inputFromUser >10 ||inputFromUser <= 0)
            {
                Console.WriteLine("Invalid number");
                Console.ReadLine();
                return;
            }
        }
        public void VerifyInputForLetters(string inputFromUser)
        {
            try
            {
                int inputFromUserConverted =Convert.ToInt32(inputFromUser);
                VerifyInputIsValid(inputFromUserConverted);
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, only digits available");
                return;
            }
        }
    }
}