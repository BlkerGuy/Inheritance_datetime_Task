using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_datetime_Task
{
    class Bicycle:Vehicle
    {
        public Bicycle(string brand, string model, int mileage) :base(brand,model,mileage)
        {

        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand} - Model:{Model} - Mileage:{Mileage} ");

        }
    }
}
