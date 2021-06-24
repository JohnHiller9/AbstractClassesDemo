using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2010-2020;
        public string Make { get; set; } = "American-made";
        public string Model { get; set; } = "Blue";

        public abstract void DriveAbstract(); //Stubbed-out method.
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");
        }
    }
}
