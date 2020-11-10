using System;
namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a Big Rig!");
        }
    }
}
