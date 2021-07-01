using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsLibrary
{
    public class Calculations
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Operation { get; set; }
        public double SumDouble { get; set; }
        public string SumString { get; set; }

        public double Add (double x, double y)
        {
            double sum = x + y;
            SumDouble = sum;
            return sum; 
        }

        public double Subtract(double x, double y)
        {
            double sum = x - y;
            SumDouble = sum;
            return sum;
        }

        public double Divide(double x, double y)
        {
            double sum = x / y;
            SumDouble = sum;
            return sum;
        }

        public double Multiply(double x, double y)
        {
            double sum = x * y;
            SumDouble = sum;
            return sum;
        }
    }
}
