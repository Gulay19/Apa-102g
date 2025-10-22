using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach.Companies
{
    internal class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }


        public Car(string brand, string model, int year, string platenumber, double fuellevel, int doorscount, int trunkcapacity, bool isautomatic, int maxspeed) : base(doorscount, trunkcapacity, isautomatic, maxspeed)
        {
            DoorsCount = doorscount;
            TrunkCapacity = trunkcapacity;
            IsAutomatic = isautomatic;
            MaxSpeed = maxspeed;
        }
        public void ShowCarInfo()
        {
            Console.WriteLine(GetVehicleInfo() + $", Doors Count: {DoorsCount}, Trunk Capacity: {TrunkCapacity}L, Is Automatic: {IsAutomatic}, Max Speed: {MaxSpeed}km/h");
        }
        public double CalculateFuelCost(double distance)
        {
            distance = 100;
            return (distance / 100) * 8 * 1.50;
        }

    }
}
