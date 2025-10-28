using System.Diagnostics;
using System.Drawing;
using _13_NullableEnumStruct.Enums;

namespace _13_NullableEnumStruct
{
    internal class Program:DrinkOrder
    {
        static void Main(string[] args)
        {

            DrinkOrder order1 = new DrinkOrder(int orderNumber, string customerName, 
                DrinkType Drink, DrinkSize Size, OrderStatus status)
            
            {
                OrderNumber = 101,
                CustomerName = "Ali",
                Drink = DrinkType.Coffee,
                Size = DrinkSize.Medium,
                status = OrderStatus.Preparing
            };

            

            
            order1.Status = OrderStatus.Ready;
            Console.WriteLine($"Yeni status: {order1.Status}");

            order1.Status = OrderStatus.Delivered;
            Console.WriteLine($"Yeni status: {order1.Status}");

            
            DrinkOrder order2 = new DrinkOrder()
            {
                OrderNumber = 102,
                CustomerName = "Leyla",
                Drink = DrinkType.Tea,
                Size = DrinkSize.Large,
                Status = OrderStatus.Ready
            };

            order2.DrinkOrder();
            Console.WriteLine($"Status: {order2.Status}");

            DrinkOrder order3 = new DrinkOrder()
            {
                OrderNumber = 103,
                CustomerName = "Vüqar",
                Drink = DrinkType.Juice,
                Size = DrinkSize.Small,
                Status = OrderStatus.Preparing
            };

            order3.DRINKOrder();


            
            Console.WriteLine("\n--- Enum dəyərləri ---");

            Console.WriteLine("DrinkType dəyərləri:");
            foreach (var drink in Enum.GetValues(typeof(DrinkType)))
                Console.WriteLine(drink);

            Console.WriteLine("\nDrinkSize dəyərləri:");
            foreach (var size in Enum.GetValues(typeof(DrinkSize)))
                Console.WriteLine(size);

            Console.WriteLine("\nOrderStatus dəyərləri:");
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
                Console.WriteLine(status);

            Console.WriteLine("\nToString nümunələri:");
            Console.WriteLine(DrinkType.Coffee.ToString());
            Console.WriteLine(DrinkSize.Large.ToString());

            Console.WriteLine("\nParse nümunələri:");
            DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
            Console.WriteLine($"Parsed drink: {parsedDrink}");
            Console.WriteLine($"Parsed size: {parsedSize}");

           
            Console.WriteLine("\n--- Statistika ---");
            Console.WriteLine("Ümumi sifariş: 3");

            decimal price1 = order1.CalculatePrice();
            decimal price2 = order2.CalculatePrice();
            decimal price3 = order3.CalculatePrice();

            Console.WriteLine($"1-ci sifarişin qiyməti: {price1} AZN");
            Console.WriteLine($"2-ci sifarişin qiyməti: {price2} AZN");
            Console.WriteLine($"3-cü sifarişin qiyməti: {price3} AZN");

            decimal total = price1 + price2 + price3;
            Console.WriteLine($"Ümumi məbləğ: {total} AZN");
        }
    }
}






























