using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Car : MotoredVehicles
    {   
    
        public bool IsOn;

        public Car(string make, string model, string prodYear, bool isOn) : base(make, model, prodYear)
        {
            this.IsOn = isOn;
        }

        public bool TurnOn()
        {
            return IsOn = true;
        }

        public bool TurnOff()
        {
            return IsOn = false;
        
        }

        
        public override string GetAllInfo()
        {
  
            return base.GetAllInfo();
        }

        public void Go()
        {
            if (IsOn = true && FuelAmount%FuelUsedPerKm>0)
            {
                int distance = FuelAmount / FuelUsedPerKm;
                Console.WriteLine($"{distance} KM driven");
            }
        }

    }    
}
