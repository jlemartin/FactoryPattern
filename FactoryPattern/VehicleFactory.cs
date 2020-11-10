using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            if (tires == 2)
            {
                return new Motorcycle();
            }
            else if (tires == 4)
            {
                Console.WriteLine("Car or BigRig?");
                Console.WriteLine("For a Car, enter 1");
                Console.WriteLine("For a BigRig, enter 2");
                var whichOne = Convert.ToInt64(Console.ReadLine());

                if (whichOne == 1)
                {
                    return new Car();
                }
                else if (whichOne == 2)
                {
                    return new BigRig();

                }
                else
                {
                    Console.WriteLine("Undecided?");
                }
                
            }
        }

    }
}
