using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        // Implementation of Property with value given for motorcycles
        public int NumOfWheels { get; set; } = 2;

        // Implementation of Drive method
        public void Drive()
        {
            Console.WriteLine("Building a Motorcycle!");
        }
    }
}
