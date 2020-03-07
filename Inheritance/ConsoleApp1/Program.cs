using System;

namespace Constructors
    {
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;
            instance.field4 = 4;
            instance.field5 = 5;

            BaseClass newInstance = (DerivedClass)instance;
            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            Console.ReadKey();
        }
    }
}
