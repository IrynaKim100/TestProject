using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calculator = new Calculator();

            Calculator.MultiplyNumbersEnteredByUser();
            Calculator.CalculateSpeed();

            Console.ReadLine();
        }
    }
}