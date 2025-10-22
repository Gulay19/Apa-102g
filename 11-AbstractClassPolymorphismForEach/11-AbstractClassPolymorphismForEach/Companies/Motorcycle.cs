using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AbstractClassPolymorphismForEach.Companies
{
    internal class Motorcycle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }    
        public int MaxSpeed { get; set; }
        public string Type { get; set; }
        public Motorcycle()
        {
            this.EngineCapacity = 600;
            this.HasSidecar = false;
            this.MaxSpeed = 190;
            this.Type = "Sport";
        }

        public Motorcycle(int enginecapacity, bool hassidecar,int maxspeed,string type):base()
        {
            EngineCapacity = enginecapacity;
            HasSidecar = hassidecar;
            MaxSpeed = maxspeed;
            Type = type;
        }
        public double ShowMotorcycleInfo(double distance)
        {
            distance = 100;
            return (distance / 100) * 4 * 1.50;
        }



    }
}
