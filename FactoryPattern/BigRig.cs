using System;
namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
        }

        public int NumOfWheels { get; set; } = 18;

        public void Drive()
        {
            Console.WriteLine("Building a Big Rig!");
        }
    }
}
