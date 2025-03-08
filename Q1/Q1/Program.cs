using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t---TRIP Detail---");
            Console.WriteLine("\t\t\t-----------------------------------------------");
            Console.WriteLine("Enter your destination :");
            string Destination = Console.ReadLine();
            Console.WriteLine("Enter total miles :");
            double Total_miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter total cost of patrol :");
            double Total_Cost_of_gasoline = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter total gallons used :");
            double Total_gallon_used = double.Parse(Console.ReadLine());
            Trip trip = new Trip(Destination,Total_miles,Total_Cost_of_gasoline,Total_gallon_used);
            trip.Miles_per_gallon();
            trip.Cost_per_mile();



        }
    }
}
