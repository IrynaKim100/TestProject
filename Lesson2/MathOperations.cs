using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class MathOperations
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

        public void ShowDistanceAsMetersPerSeconds(string distance, string hours, string minutes, string seconds)
        {

            try
            {
                int dist = Convert.ToInt32(distance);
                int hou = Convert.ToInt32(hours);
                int minu = Convert.ToInt32(minutes);
                int sec = Convert.ToInt32(seconds);
                int speed = dist * 1000 / sec;
                Console.WriteLine($"speed : {speed}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid data entered");
            }
        }

        public void ShowDistanceAsKilometersPerHours(string distance, string hours, string minutes, string seconds)
        {
            try
            {
                int dist = Convert.ToInt32(distance);
                int hou = Convert.ToInt32(hours);
                int minu = Convert.ToInt32(minutes);
                int sec = Convert.ToInt32(seconds);
                int speed = dist / hou;
                Console.WriteLine($"speed : {speed}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid data entered");
            }
        }

        public void ShowDistanceAsKilometersPerMiles(string distance, string hours, string minutes, string seconds)

        {

        }
    }
}
