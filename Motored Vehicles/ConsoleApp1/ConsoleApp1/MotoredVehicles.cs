using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MotoredVehicles
    {
        public string Make;
        public string Model;
        public string ProdYear;
        public string Color;
        public string Transmission;
        public string MotorSize;
        public string Horsepower;
        public int FuelTankSize;
        public int FuelAmount;
        public int FuelUsedPerKm;
        public int PassengerCount;

        public MotoredVehicles()
        {
            Console.WriteLine("Motored Vehicle is added!");
        }

        public MotoredVehicles(string make, string model, string prodYear)
        {
            this.Make = make;
            this.Model = model;
            this.ProdYear = prodYear;
        }

        public string GetInfo()
        {

            return $"{Make} /{Model} / {ProdYear}";

        }

        public virtual string  GetAllInfo()
        {

            return $"{Make} /{Model} /{ProdYear} /{Color} /{Transmission} /{MotorSize} /{Horsepower} /{FuelTankSize} /{FuelAmount} /{FuelUsedPerKm}/{PassengerCount}";

        }




    }
}
