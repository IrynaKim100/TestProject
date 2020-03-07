using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            Console.WriteLine(instance.publicField);

            instance.Show();
            Console.ReadKey();
        }
    }
}
