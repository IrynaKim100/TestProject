using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class BaseClass
    {
        public int field1;
        public int field2;
        public int field3;
        public int baseNumber;

        public BaseClass()
        {

        }

        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
