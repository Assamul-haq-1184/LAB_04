using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tBOOK DETAILS");
            Book books = new Book();
            books.InputBook();
            while (true)
            {
                Console.WriteLine("\t\t\t\t\t\tLIBARAY MANAGEMENT");
                Console.WriteLine("\t\t\t\t-----------------------------------------------------\n");

                Console.WriteLine("1-Display all books detail.");

                Console.WriteLine("2-Search specific book.");
                Console.WriteLine("3-Exit program");
                Console.WriteLine("Enter your choice :");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        books.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter the title of the book which you want to search :");
                        string name = Console.ReadLine();
                        books.Search(name);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        break;

                }

            }


        }
    }
}
