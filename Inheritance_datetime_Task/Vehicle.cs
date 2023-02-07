using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_datetime_Task
{
     class Vehicle
    {
        public string Brand;
        public string Model;
        public int Mileage;


        public Vehicle(string brand, string model, int mileage)
        {
            Brand = brand;
            Model = model;
            Mileage = mileage;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand} - Model:{Model} - Mileage:{Mileage}");
        }

    }
}
