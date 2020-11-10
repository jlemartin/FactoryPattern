using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public int NumOfWheels { get; set; } = 2;

        public void Drive()
        {
            Console.WriteLine("Building a Motorcycle!");
        }
    }
}
