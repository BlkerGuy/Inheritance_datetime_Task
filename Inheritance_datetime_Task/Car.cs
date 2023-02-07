using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_datetime_Task
{
     class Car:Vehicle
    {
        public byte FuelCapacity;


        public Car(string brand, string model, int mileage,byte fuelCapacity) : base(brand,model,mileage)
        {
            FuelCapacity = fuelCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand} - Model:{Model} - Mileage:{Mileage} - FuelCapacity:{FuelCapacity}");

        }
    }
}
