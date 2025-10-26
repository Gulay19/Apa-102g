using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceAbstraction
{
    internal class Calculation 
    {
        public void FindCalculation(ICalculation calculation, double a, double b)
        {
            calculation.Calculator(a, b);
        }


    }
}
