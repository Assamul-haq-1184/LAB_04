using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class MealCard
    {
        private string Student_name;
        private int Balance;

        private int Default_balance = 100;
        public MealCard(string student_name, int balance )
        {
            Student_name = student_name;
            
            if (balance <= 0)
             balance = Default_balance;
            Balance = balance;
        }
        public void Add_points(int points)
        {
            if (points > 0)
            {
                Balance += points;
                Console.WriteLine($"Added points in card balance is RS:{points}");
            }
            else
            {
                Console.WriteLine("Invalid Points must be greater than zero to increase Balance.");
            }
                
        }
        public void Purchase(int price)
        {
            if (price > 0)
            {
                if (Balance >= price)
                {
                    Balance -= price;
                    Console.WriteLine($"Food Purchase for RS:{price} . Remaining balance is RS:{Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance .");
                }
                
            }
            else
            {
                Console.WriteLine("Cost of food is more than balance.");
            }

        }
        public void Display()
        {
            Console.WriteLine($"Student Name : {Student_name}");
            Console.WriteLine($"Card Balance : {Balance}");

        }
    }
}
