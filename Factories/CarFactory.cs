

namespace YH_Inlämning_2__factory.Factories
{
    using YH_Inlämning_2_Car_factory.Interface;
    using YH_Inlämning_2_Car_factory.Interfaces;
    using YH_Inlämning_2_Car_factory.Models;

    public class CarFactory : IVehicleFactory
    {
        private string brand { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private double mileage { get; set; }
        private int doors { get; set; }

        public CarFactory(string brand, string model, int year, double mileage, int doors)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.doors = doors;
        }
        public IVehicle CreateVehicle()
        {
            return CreateCar();
        }
        public CarImpl CreateCar()
        {
            return new CarImpl(brand, model, year, mileage, doors);
        }
    }
}
