using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach.Companies
{
    internal class Truck
    {
        public double CargoCapacity { get; set; }
        public int AxlesCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }
        public Truck()
        {
            this.CargoCapacity = 5000;
            this.AxlesCount = 4;
            this.CurrentLoad = 4;
            this.MaxSpeed = 120;
        }
        public Truck(double cargocapacity, int axlescount, double currentload, int maxspeed) : base()
        {
            CargoCapacity = cargocapacity;
            AxlesCount = axlescount;
            CurrentLoad = currentload;
            MaxSpeed = maxspeed;
        }
        public void ShowTruckInfo()
        {
            Console.WriteLine($"Cargo Capacity: {CargoCapacity}kg, Axles Count: {AxlesCount}, Current Load: {CurrentLoad}, Max Speed: {MaxSpeed}km/h");
        }
        public double LoadCargo(double distance)
        {
            distance = 100;
            return (distance / 100) * (25 + CurrentLoad * 2) *1.80;
        }
    }
}
