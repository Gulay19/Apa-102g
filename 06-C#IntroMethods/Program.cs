using System;
namespace Task_6
{
    class RiyaziEmel
    {
        public static int Transaction(int a, int b, char operation)
        {
            int result = 0;
            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b != 0)
                        result = a / b;
                    else
                        Console.WriteLine("0 ilə bölmək olmaz");
                    break;
                default:
                    Console.WriteLine("Səhv əməliyyat");
                    break;
            }
            return result;
        }
    }

    class TekCut
    {
        public static void TekCutReqem(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i] + " cütdür");
                else
                    Console.WriteLine(numbers[i] + " təkdir");
            }
        }
    }


    class ReqemBolunme
    {
        public static int reqemBolunme(params int[] numb)
        {
            int sum = 0;
            for (int i = 0; i < numb.Length; i++)
            {
                if (numb[i] % 4 == 0 && numb[i] % 5 == 0)
                {
                    sum += numb[i];
                }
            }
            return sum;
        }

    }
    

    class SimvolSayi {
         public static int Count(string cumle, string sim)
        {
            int cem = 0;
            char simvol = sim[0];
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == simvol)
                {
                    cem++;
                }
            }
            return cem;
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            // RiyaziEmel test
            int a = 10;
            int b = 5;
            char op = '+';
            int result = RiyaziEmel.Transaction(a, b, op);
            Console.WriteLine($"{a} {op} {b} = {result}");

            // TekCut test
            int[] arr = { 14, 20, 35, 40, 57, 60, 100 };
            TekCut.TekCutReqem(arr);

            // reqemBolunme test
            int[] numbers = { 14, 20, 35, 40, 57, 60, 100 };
            int sum = ReqemBolunme.reqemBolunme(numbers);
            Console.WriteLine("4 və 5-ə tam bölünən ədədlərin cəmi: " + sum);

            // SimvolSayi test
            string cumle = "Mən Kənan Rzayevəm. Mən backend developerəm.";   
            string sim = "a";
            int say = SimvolSayi.Count(cumle, sim);
            Console.WriteLine("Cümlədəki " + sim + " simvolunun sayı: " + say);
        }
    }
}


