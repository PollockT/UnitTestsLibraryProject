using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLibrary
{
    public class DivisionClass
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public DivisionClass()
        {

        }

        public DivisionClass(int a, int b)
        {
            FirstNum = a;
            SecondNum = b;
        }
        public int DivisionCall(int a, int b)
        {
            return a / b;
        }
    }
}
