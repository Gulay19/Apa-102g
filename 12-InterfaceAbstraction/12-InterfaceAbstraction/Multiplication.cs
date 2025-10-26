using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceAbstraction
{
    internal class Multiplication : ICalculation
    {
        public void Calculator(double a, double b)
        {
            double product = a * b;
            Console.WriteLine("Multiplication: " + product);

        }
    }
}
