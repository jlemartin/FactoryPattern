using System;
namespace FactoryPattern
{
    public interface IVehicle
    {
        // Property to be used by Classes
        public int NumOfWheels { get; set; }

        // stubbed out Drive method - for classes to implement
        public void Drive();

    }
}
