using ClassTask1.Models;
using System;

namespace ClassTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("make","bmw","2001");
            Console.WriteLine("is car on? true or false");
             bool status = Convert.ToBoolean(Console.ReadLine());

            if (status==true)
            {
                car.isOn();
                Console.WriteLine("please enter dictance ");
                car.distance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter th fuel amount");
                car.fuelAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("And the fuel use per km ");
                car.fuelUsedPerKm = Convert.ToDouble(Console.ReadLine());
                car.GetDetailedInfo(car.fuelAmount, car.fuelUsedPerKm);
                car.Go();
            }
            else
            {
                car.isOf();
            }

            
            
            

        }
    }
}
