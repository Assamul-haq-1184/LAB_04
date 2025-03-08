using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Trip
    {
       private string Destination;
       private double Distance_Travel;
       private double Total_Cost_of_gasoline;
       private double Total_gallon_used;
        public Trip(string Destination, double Distance_Travel, double Total_Cost_of_gasoline, double Total_gallon_used)

        {
            this.Destination = Destination;
            this.Distance_Travel = Distance_Travel;
            this.Total_Cost_of_gasoline = Total_Cost_of_gasoline;
            this.Total_gallon_used = Total_gallon_used;
        }
        public void Miles_per_gallon()
        {
            double mile_per_gallon = Distance_Travel/Total_gallon_used;
            Console.WriteLine($"Miles per Gallon = {mile_per_gallon}");
        }
        public void Cost_per_mile()
        {
            double cost_per_mile = Total_Cost_of_gasoline/Distance_Travel ;
            Console.WriteLine($"Miles per Gallon = {cost_per_mile}");
        }
    }
}
