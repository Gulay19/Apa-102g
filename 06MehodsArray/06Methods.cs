namespace MethodsDers6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 14, 20, 35, 40, 57, 60, 100 };


            //SimvolunSayiniTap("Salam necesen", 'e');


            //DordeBesBolunenlerinCemi(arr);

            //TekCut(arr);
        }
        //4.Daxil edilmiş cümlədə daxil edilmis simvoldan nece eded olduğunu tapan Proqramın alqoritmini yazin.(Cumle serbestdir).
        #region SimvolTapan
        //public static void SimvolunSayiniTap(string cumle, char simvol)
        //{
        //    int count = 0;
        //    for (int i = 0; i < cumle.Length; i++)
        //    {
        //        if (cumle[i] == simvol)
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine($"Cumlede '{simvol}' simvolu {count} defe isdifade olunub.");
        //} 
        #endregion

        //3.Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]
        #region 4ve5Bolunen
        //public static void DordeBesBolunenlerinCemi(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 4 == 0 && arr[i] % 5 == 0)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    Console.WriteLine("4-e ve 5-e bolunen ededlerin cemi: " + sum);
        //} 
        #endregion



        //2.Verilen arqumentlere uygun tek ve cut edeleri tapan method yazin.(14, 20, 35, 40, 57, 60, 100)
        #region TekCut
        //public static void TekCut(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            Console.WriteLine(arr[i] + ": cut ededdir");
        //        }


        //        else
        //        {
        //            Console.WriteLine(arr[i] + ": tek ededdir");
        //        }
        //    }

        //} 
        #endregion

        //1.Hər biri 2 parametr qəbul edib və riyazi əməlləri yerinə yetiren method yazin.
        #region RiyaziEmeller
        //public static void RiyaziEmel(int a, int b)
        //{
        //    switch (RiyaziEmel)
        //    {
        //        case 1:
        //            Console.WriteLine(a + b);
        //            break;
        //        case 2:
        //            if (a > b)
        //            {
        //                Console.WriteLine(a - b);
        //            }
        //            else (b > a)
        //            {
        //                Console.WriteLine(b - a);
        //            }
        //            break;
        //        case 3:
        //            Console.WriteLine(a * b);
        //            break;
        //        case 4:
        //            if (a != 0 && a=> b)
        //            {
        //                Console.WriteLine(a / b);
        //            }
        //            else if (b != 0 && b > a)
        //            {
        //                Console.WriteLine(b / a);
        //            }
        //            else
        //            {
        //                Console.WriteLine("0-a bolme olmaz");

        //            }

        //            break;
        //        default:
        //            Console.WriteLine("Duzgun emel secin");
        //            break;
        //    }
        //}
        #endregion



    }
}

























