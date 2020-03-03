using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class InputValidations
    {
        private void VerifyInputIsValid(int inputFromUser)
        {
            if (inputFromUser > 10 || inputFromUser <= 0)
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
                int inputFromUserConverted = Convert.ToInt32(inputFromUser);
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
