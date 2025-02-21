using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Test
{
    internal class C
    {
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        public double babylonSqrt(double a)
        {
            double guess = a / 2;
            while (Math.Abs(guess* guess - a) < 0.01)
            {
                double other = a / guess;
                guess = (guess+other)/2;
            }
            return guess;
        }
    }
}
