using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mazda", "3", "2015", true);
            Console.WriteLine(car1.GetAllInfo());

        }
    }
}
