using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16_6_1
{
    public class Calculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        public int Miltiplication(int a, int b, int c)
        {
            return a * b * c;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
