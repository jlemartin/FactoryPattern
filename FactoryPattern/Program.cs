using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of wheels for vehicle:");
            var wheelCount = Convert.ToInt32(Console.ReadLine());

            var newVehicle = VehicleFactory.GetVehicle(wheelCount);
            newVehicle.Drive();
            Console.WriteLine($"This vehicle has {newVehicle.NumOfWheels} wheels.");

        }
    }
}
