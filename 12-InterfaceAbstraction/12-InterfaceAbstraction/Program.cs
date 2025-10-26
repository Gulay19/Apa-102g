namespace _12_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=======================");
            Console.WriteLine("Select operation: ");
            Console.WriteLine("1- Addition");
            Console.WriteLine("2- Subtraction");
            Console.WriteLine("3- Multiplication");
            Console.WriteLine("4- Division");



            int choise = Convert.ToInt32(Console.ReadLine());


            ICalculation addition = new Additional();
            ICalculation subtraction = new Subtraction();
            ICalculation multiplication = new Multiplication();
            ICalculation division = new Division();
            addition.Calculator(a, b);
            subtraction.Calculator(a, b);
            multiplication.Calculator(a, b);
            division.Calculator(a, b);



            switch (choise)
            {
                case 1:
                    addition.Calculator(a, b);
                    break;
                case 2:
                    subtraction.Calculator(a, b);
                    break;
                case 3:
                    multiplication.Calculator(a, b);
                    break;
                case 4:
                    division.Calculator(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}



