using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceAbstraction
{
    internal class Subtraction : ICalculation
    {
        public void Calculator(double a, double b)
        {
            if (a >= b)
            {
                double difference = a - b;
                Console.WriteLine("Subtraction: " + difference);
            }
            else
            {
                double difference = b - a;
                Console.WriteLine("Subtraction: " + difference);
            }
        }
    }
}
