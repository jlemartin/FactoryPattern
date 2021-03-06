﻿using System;
namespace FactoryPattern
{
    // Where the IVehicles are 'made' - static class
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheels)
        {
            switch (wheels)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 18:
                    return new BigRig();
                default:
                    return new Car();
            }

           
        }

    }
}
