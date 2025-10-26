using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceAbstraction
{
    internal class Division : ICalculation
    {
        public void Calculator(double a, double b)
        {
            if (b != 0)
            {
                double Bolme = a / b;
                Console.WriteLine("Division: " + Bolme);
            }
            else
            {
                Console.WriteLine("No!");
            }

        }
    }
}
