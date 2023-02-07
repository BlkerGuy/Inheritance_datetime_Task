using System;

namespace Inheritance_datetime_Task
{
     class Program
    {
        static void Main(string[] args)
        {

            #region  TASK 1 done
            Car car = new Car("BMW","M5",200000,68);
            Car car2 = new Car("BMW", "X5", 282000, 80);
            Car car3 = new Car("HUMMER", "H3 Alpha", 300000, 87);

            Bicycle bike = new Bicycle("AVENTON", "PACE 500", 48);
            Bicycle bike2 = new Bicycle("CANYON AEROAD", "CF SLX 7", 64);
            Bicycle bike3 = new Bicycle("GHOST-BIKES", "RIOT EN PRO", 37);


            //car.ShowInfo(); 

            Console.WriteLine("Cars:");
            Car[] carsArr = new Car[] { car, car2, car3 };
            for (int i = 0; i < carsArr.Length; i++)
            {
                carsArr[i].ShowInfo();
            }

            Console.WriteLine("\nBicycles:");
            Bicycle[] bikeArr = new Bicycle[] { bike, bike2, bike3 };
            for (int i = 0; i < carsArr.Length; i++)
            {
                carsArr[i].ShowInfo();
            }

            #endregion



            #region  TASK 2 done
            //Console - dan bir tarix daxil edin,
            //daha sonra consoledan tarixe elave etmek istediyiniz illeri daxil edin,
            //ve yeni tarixi console penceresinde gun - ay - il seklinde gosterin

            DateTime date;

            Console.WriteLine("\nPlease enter date:");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter Years:");
            var dateYears = Convert.ToInt32(Console.ReadLine());
            var newDate = date.AddYears(+dateYears);
            
            Console.WriteLine(newDate.ToString("dd-MM-yyyy"));

























            #endregion




















        }
    }
}
