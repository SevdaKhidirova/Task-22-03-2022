using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask1.Models
{
    class MotoredVehicle
    {
        public string make;
        public string model;
        public string productionYear;
        public int motorSize;
        public double fuelTankSize;
        public double fuelAmount;
        public double fuelUsedPerKm;
        public string color;
        public int passengerCount;


        public void GetInfo()
        {
            make = "Camry";
            model = "Bmw";
            color = "black";
        }
        public void GetDetailedInfo()
        {
            productionYear = "2001";
            fuelTankSize = 80;
           // fuelAmount = 60;
            fuelUsedPerKm = 1;
        }

        public MotoredVehicle(string make,string model,string productionYear)
        {
            this.make = make;
            this.model = model;
            this.productionYear = productionYear;
        }
        public MotoredVehicle()
        {

        }
    }
}
