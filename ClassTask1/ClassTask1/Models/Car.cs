using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask1.Models
{
    class Car: MotoredVehicle
    {
        public int horsePower;
        public bool status = true;
        public double distance;

         public void GetDetailedInfo(double fuelAmount,double fuelUsedPerKm)
        {
            this.fuelAmount = fuelAmount;
            this.fuelUsedPerKm = fuelUsedPerKm;
        }

        public Car()
        {
            fuelUsedPerKm = 1;
            fuelAmount = 60;
            fuelTankSize = 80;
        }

        public void isOn()
        {

            Console.WriteLine("davam ede bilersiniz");
            
        }
        public void isOf()
        {
            Console.WriteLine("you dont turn on Car");
            return;
        }

        public void Go()
        {
            double result = distance * fuelUsedPerKm;
            if (result > fuelAmount)
            {
                Console.WriteLine("There is no enough fuel ");
            }
            else if (distance > 0 && fuelUsedPerKm>0)
            {
                Console.WriteLine(distance + " km distance ");
            }
            else
            {
                Console.WriteLine("Something wents wrong :)");
                return;
            }

        }
        

        public Car(string model,string make,string year):base(model,make,year)
        {

        }



    }
}
