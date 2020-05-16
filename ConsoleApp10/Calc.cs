using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
   public class Calc
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Multi(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
