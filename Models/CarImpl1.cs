using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YH_Inlämning_2_Car_factory.Interface;

namespace YH_Inlämning_2_Car_factory.Models
{
    public class CarImpl : ICar, IDriveable
    {
        public int Doors { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        private bool engineOn = false;

        public CarImpl(string brand, string model, int year, double mileage, int doors)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.Doors = doors;
        }

        public string Drive()
        {
            if (engineOn)
            {
                Mileage += 10;
                return "Car is Driveable & Ready for test dive. Went for a ride of 10 Miles.";
            }
            else
            {
                return "Engine is off, Start the engine first.";
            }
        }

        public bool IsEngineOn()
        {
            return engineOn;
        }

        public void StartEngine()
        {
            engineOn = true;
            Console.WriteLine("Car Engine on.");
        }

        public void StopEngine()
        {
            engineOn = false;
            Console.WriteLine("Car Engine off.");

        }
        public override string ToString()
        {
            return $"Car: {Brand}. {Model} made in: ({Year}) worked for {Mileage} miles and has {Doors} doors.";
        }

    }
}

