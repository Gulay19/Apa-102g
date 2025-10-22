using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach.Companies
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int  Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }

        protected Vehicle(string brand, string model, int year, string PlateNumber,double FuelLevel)
        {
            Brand = brand;
            Model = model; 
            Year = year;
            PlateNumber = PlateNumber;
            FuelLevel = FuelLevel;

        }
   
        protected Vehicle()
        {
            this.Brand = "Kia";
            this.Model = "Sorento";
            this.Year = 2023;
            this.PlateNumber = "19-gh-019";
            this.FuelLevel = 100;



        }

        public string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate Number: {PlateNumber}, Fuel Level: {FuelLevel}%";
        }
        public void ShowBasicInfo() 
        {
            Console.WriteLine(GetVehicleInfo());
        }


    }
}
