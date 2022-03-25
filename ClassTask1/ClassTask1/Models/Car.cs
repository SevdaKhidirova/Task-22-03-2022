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
        public bool IsOn;

        public void TurnOn()
        {
            if (IsOn)
            {
                //Console.WriteLine("Car is alreday on");
            }
            else
            {
                IsOn = true;
                Console.WriteLine("Car is turned on");
            }
        }
        public void TurnOf()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine("Car turned off  BYEE");
            }
            else
            {
               // Console.WriteLine("Car is already off!");
            }

        }


        public void GetDetailedInfo(double fuelAmount,double fuelUsedPerKm)
        {
            this.fuelAmount = fuelAmount;
            this.fuelUsedPerKm = fuelUsedPerKm;
        }

        public Car(string make,string model,string productionYear):base(make,model,productionYear)
        {
            
        }

        

        public void Go()
        {
            if (IsOn)
            {
                if(distance * fuelUsedPerKm <= fuelAmount)
                {
                    fuelAmount -= distance * fuelUsedPerKm;
                    Console.WriteLine($"Car went {distance} km, Remaining fuel {fuelAmount}");
                }
                else
                {
                    Console.WriteLine($"not enough fuel! Available range: {fuelAmount/fuelUsedPerKm}");
                }
            }
            else
            {
                Console.WriteLine("Car is off!");
            }

        }
        

     



    }
}
