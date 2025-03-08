using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student card balance :If you enter 0 or less than 0 then default balance is RS:100  ");
            int balance = int.Parse(Console.ReadLine());
            MealCard mealCard = new MealCard(name,balance);
            mealCard.Display();
            
            mealCard.Purchase(19);

            mealCard.Purchase(800);
            mealCard.Add_points(100);

            mealCard.Purchase(80);
            mealCard.Display();


        }
    }
}
