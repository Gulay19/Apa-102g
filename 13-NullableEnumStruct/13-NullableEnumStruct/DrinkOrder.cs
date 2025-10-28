using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_NullableEnumStruct.Enums;

namespace _13_NullableEnumStruct
{
    internal class DrinkOrder
    {

        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }

        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }

        public DrinkOrder(int orderNumber, string customerName, DrinkType drink,
            DrinkSize size, OrderStatus status, decimal price)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = status;
            Price = price;
        }



            public decimal CalculatePrice(string drinkType, string size)
            { 
        
            decimal price = 0;

            switch (drinkType.ToLower())
            {
                case "coffee":
                    switch (size.ToLower())
                    {
                        case "small": price = 3; break;
                        case "medium": price = 4; break;
                        case "large": price = 5; break;
                        default: throw new ArgumentException("Yanlış ölçü daxil edilib.");
                    }
                    break;

                case "tea":
                    switch (size.ToLower())
                    {
                        case "small": price = 2; break;
                        case "medium": price = 3; break;
                        case "large": price = 4; break;
                        default: throw new ArgumentException("Yanlış ölçü daxil edilib.");
                    }
                    break;

                case "juice":
                    switch (size.ToLower())
                    {
                        case "small": price = 4; break;
                        case "medium": price = 5; break;
                        case "large": price = 6; break;
                        default: throw new ArgumentException("Yanlış ölçü daxil edilib.");
                    }
                    break;

                case "water":
                    switch (size.ToLower())
                    {
                        case "small": price = 1m; break;
                        case "medium": price = 1.5m; break;
                        case "large": price = 2m; break;
                        default: throw new ArgumentException("Yanlış ölçü daxil edilib.");
                    }
                    break;

                default:
                    throw new ArgumentException("Yanlış içki növü daxil edilib.");
            }

            return price;
        }
}
}






















    





    //Coffee: Small=3, Medium=4, Large=5
    //Tea: Small=2, Medium=3, Large=4
    //Juice: Small=4, Medium=5, Large=6
    //Water: Small=1, Medium=1.5, Large=2
    //Switch statement istifadə edin





