using ClassTask1.Models;
using System;

namespace ClassTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("make", "bmw", "2001");
            string answer = "y"; // char olmali idi ancaq sehven string daxil oluna biler deye string yazdim
            while (answer == "y")
            {  
                Console.WriteLine("is car on? true or false");
                car.IsOn = Convert.ToBoolean(Console.ReadLine());
                car.TurnOn();

                Console.WriteLine("pls enter the fuelAmount ");
                car.fuelAmount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" enter the fuelUsedPerKm ");
                car.fuelUsedPerKm = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("pls enter the distance ");
                car.distance = Convert.ToDouble(Console.ReadLine());


                if (car.fuelAmount >= 0 && car.fuelUsedPerKm > 0 && car.distance >= 0)
                {
                    car.Go();
                }
                else
                {
                    Console.WriteLine("SOMETHING WENTS WRONG :)  ");
                }
                Console.WriteLine(" DO YOU WANT TO TRY AGAIN ? YES (Y) OR NO (N)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                    break;
            }

            car.TurnOf();


        }
    }
}
