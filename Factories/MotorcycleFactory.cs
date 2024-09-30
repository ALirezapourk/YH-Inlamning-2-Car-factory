


using YH_Inlämning_2_Car_factory.Interface;
using YH_Inlämning_2_Car_factory.Interfaces;
using YH_Inlämning_2_Car_factory.Models;

namespace YH_Inlämning_2_Car_factory.Factories
{
    public class MotorcycleFactory : IVehicleFactory
    {
        private string brand { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private double mileage { get; set; }
        private string engineType { get; set; }

        public MotorcycleFactory(string brand, string model, int year, double mileage, string engineType)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.engineType = engineType;
        }
        public IVehicle CreateVehicle()
        {
            return CreateMotorcycle();
        }
        public MotorcycleImpl CreateMotorcycle()
        {
            return new MotorcycleImpl(brand, model, year, mileage, engineType);
        }
    }
}