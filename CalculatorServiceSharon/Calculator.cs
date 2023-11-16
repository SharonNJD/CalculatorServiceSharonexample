using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceSharon
{
    public class Calculator : ICalculator
    {
        public double Div(double x, double Y)
        {
           return x/Y;
        }

        public double Mul(double x, double Y)
        {
           return x*Y;
        }

        public double Sub(double x, double Y)
        {
            return x-Y;
        }

        public double Sum(double x, double Y)
        {
           return x+Y;
        }
    }
}
