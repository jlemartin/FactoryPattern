using System;
namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public int NumOfWheels { get; set; } = 4;

        public void Drive()
        {
            Console.WriteLine("Building a Car!");
        }
    }
}
