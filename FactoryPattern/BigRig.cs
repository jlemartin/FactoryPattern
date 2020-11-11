using System;
namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
        }

        // Value set for BigRigs - 18-wheelers
        public int NumOfWheels { get; set; } = 18;

        // Implementation of Drive method
        public void Drive()
        {
            Console.WriteLine("Building a Big Rig!");
        }
    }
}
