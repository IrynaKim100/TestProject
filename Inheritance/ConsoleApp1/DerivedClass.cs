using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{    
    class DerivedClass : BaseClass
    {
        public int field4;
        public int field5;
        public int derivedField;

        public DerivedClass()
        {

        }
        public DerivedClass(int number1, int number2)
            :base(number1)
        {
            this.derivedField = number2;
        }
    }
}
