using YH_Inlämning_2__factory.Factories;
using YH_Inlämning_2_Car_factory.Factories;
using YH_Inlämning_2_Car_factory.Interface;
using YH_Inlämning_2_Car_factory.Interfaces;

namespace YH_Inlämning_2_Car_factory
{
    
        internal class Program
        {
            static void Main()
            {
                // Create a list of IVehicle objects    
                List<IVehicle> vehicles = new List<IVehicle>();

                // Instantiate the specific factories
                CarFactory car1 = new CarFactory("Lightning Mcqueen", "Chevrolet Corvette C6", 2005, 31000, 2);
                MotorcycleFactory motorcycle1 = new MotorcycleFactory("Harley Davidson", "Sportster", 2009, 6000, "V-Twin");
                CarFactory car2 = new CarFactory("Chevrolet", "Camaro", 2018, 20000, 2);
                MotorcycleFactory motorcycle2 = new MotorcycleFactory("Ducati", "Panigale", 2017, 10000, "V4");
                CarFactory car3 = new CarFactory("Batmobil", "Burton-mobile", 1989, 66666666, 2);
                MotorcycleFactory motorcycle3 = new MotorcycleFactory("customized SpazFrag666","Lobo", 1983, 9999999999999, "miniaturized 17-liter powerplant ");


            //Adding vehicles to List
            vehicles.Add(car1.CreateVehicle());
                vehicles.Add(motorcycle1.CreateVehicle());
                vehicles.Add(car2.CreateVehicle());
                vehicles.Add(motorcycle2.CreateVehicle());
                vehicles.Add(car3.CreateVehicle());
                vehicles.Add(motorcycle3.CreateVehicle());
               

            foreach (IVehicle vehicle in vehicles)
                {
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine(vehicle);
                    if (vehicle.IsEngineOn() == true)
                    {
                        vehicle.StartEngine();
                    }
                    if (vehicle is IDriveable driveable)
                    {
                        Console.WriteLine(driveable.Drive());
                    }
                    vehicle.StopEngine();
                    Console.WriteLine();
                }
            }
        }
    }
