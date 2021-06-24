using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
            Year = 2015;
            Make = "Toyota";
            Model = "Camry";
        }

        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Car is in drive.");
        }
    }
}
