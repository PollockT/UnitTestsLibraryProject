using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLibrary
{
    public class AdditionClass
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public AdditionClass()
        {

        }

        public AdditionClass(int a, int b)
        {
            FirstNum = a;
            SecondNum = b;
        }
        public int AdditionCall(int a, int b)
        {
            return a + b;
        }
    }
}
