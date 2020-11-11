using System;
namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        // Value set for cars
        public int NumOfWheels { get; set; } = 4;

        // Implementation of Drive method
        public void Drive()
        {
            Console.WriteLine("Building a Car!");
        }
    }
}
