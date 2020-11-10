using System;
namespace FactoryPattern
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }

        public void Drive();

    }
}
