using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YH_Inlämning_2_Car_factory.Interface;

namespace YH_Inlämning_2_Car_factory.Models
{
    public class MotorcycleImpl : IMotorcycle, IDriveable
    {
        public string EngineType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        private bool EngineOn = false;

        public MotorcycleImpl(string brand, string model, int year, double mileage, string engineType)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.EngineType = engineType;
        }

        public bool IsEngineOn()
        {
            return EngineOn;
        }

        public void StartEngine()
        {
            EngineOn = true;
            Console.WriteLine("Motorcyle engine is on.");
        }

        public void StopEngine()
        {
            EngineOn = false;
            Console.WriteLine("Motorcycle engine off.");
        }

        public string Drive()
        {
            if (EngineOn)
            {
                Mileage += 10;
                return "Motorcycle is Driveable & Ready for test drive. Went on for ride of 10 Miles.";
            }
            else
            {
                return "Engine is off, Start the engine first.";
            }
        }

        public override string ToString()
        {
            return $"Motorcycle: {Brand}. {Model} made is: ({Year}) worked for {Mileage} miles and It's EngineType is {EngineType}.";
        }
    }
}
