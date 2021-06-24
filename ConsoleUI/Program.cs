using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DONE follow all comments!! 
             */

            #region Vehicles

            /*  //DONE
             * Create an abstract class called Vehicle
             *  //DONE
             * The vehicle class shall have three string properties Year, Make, and Model
             *  //DONE
             * Set the defaults to something generic in the Vehicle class
             *  //DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             *  //DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /*  //DONE
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *  //DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *  //DONE
             * Provide the implementations for the abstract methods
             *  //DONE
             * Only in the Motorcycle class will you override the virtual drive method
            */

            //DONE
            // Create a list of Vehicle called vehicles
            var Vehicles = new List<Vehicle>();

            //DONE
            //Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes

            Car car1 = new Car() { HasTrunk = true, Year = 2013, Make = "Ford", Model = "Focus" };
            Motorcycle cycle2 = new Motorcycle() { HasSideCart = false, Year = 2016, Make = "Honda", Model = "Cycle" };

            Vehicle sedan = new Car() { HasTrunk = true, Year = 2010, Make = "Toyota", Model = "Red" };
            Vehicle harley = new Motorcycle() { HasSideCart = true, Year = 2017, Make = "Harley Davidson", Model = "Black" };

            //DONE
            //Add the 4 vehicles to the list
            Vehicles.Add(car1);
            Vehicles.Add(cycle2);
            Vehicles.Add(sedan);
            Vehicles.Add(harley);

            //DONE
            //Using a foreach loop iterate over each of the properties
            //DONE
            // Call each of the drive methods for one car and one motorcycle
            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveAbstract();
                Console.WriteLine($"--------------------");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
