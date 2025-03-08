using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Dividend :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number for Divisor :");
            int n2 = int.Parse(Console.ReadLine());
            Fraction fraction = new Fraction(n1,n2);
            Console.Write($"Fraction = ");
            fraction.Display();
           
        }
    }
}
