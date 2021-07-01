using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLibrary
{
    public class MultiplicationClass
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public MultiplicationClass()
        {

        }
        public MultiplicationClass(int a, int b)
        {
            FirstNum = a;
            SecondNum = b;
        }

        public int MultiplicationCall(int a, int b)
        {
            return a * b;
        }
    }
}
