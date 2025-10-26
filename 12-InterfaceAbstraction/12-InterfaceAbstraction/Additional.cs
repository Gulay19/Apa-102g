using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceAbstraction
{
    internal class Additional : ICalculation
    {
        public void Calculator(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine("Addition: " + sum);

        }
    }
}
