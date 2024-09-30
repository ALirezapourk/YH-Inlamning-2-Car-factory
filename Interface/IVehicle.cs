using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH_Inlämning_2_Car_factory.Interfaces
{
    using YH_Inlämning_2_Car_factory.Factories;
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double Mileage { get; set; }

        bool IsEngineOn();
        void StartEngine();
        void StopEngine();
    }
}