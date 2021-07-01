using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLibrary
{
    public class SubtractionClass
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public SubtractionClass()
        {

        }
        public SubtractionClass(int a, int b)
        {
            FirstNum = a;
            SecondNum = b;
        }

        public int SubtractionCall(int a, int b)
        {
            return a - b;
        }
    }
}
