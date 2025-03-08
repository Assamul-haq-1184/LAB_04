using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Book
    {
        private int[] ISBN=new int[2];
        private string[] Title=new string [2];
        private int[] Price =new int [2];
        private string []Major_Area= new string [2];
        private string[] Sub_Area =new string[2];
        private int[] NO_of_Pages= new int [2];
        public void InputBook()
        {
            
            Console.WriteLine("\t\t\t\t-----------------------------------------------------");
            
            for (int i = 0; i < Title.Length; i++)
            {
                Console.WriteLine($"->Enter detail of BOOK-{i + 1}");
                Console.WriteLine($"Enter isbn of book :");
                 ISBN[i] = int.Parse(Console.ReadLine());
          
                Console.WriteLine($"Enter Title of book :");
                Title[i] = Console.ReadLine();
                

                Console.WriteLine($"Enter Price of book :");
                Price[i] = int.Parse(Console.ReadLine());
               

                Console.WriteLine($"Enter Major topic of book :");
                Major_Area[i] = Console.ReadLine();
                
                Console.WriteLine($"Enter Sub Topic of book :");
                Sub_Area[i] = Console.ReadLine();
              
                Console.WriteLine($"Enter NO. of Pages of book :");
                NO_of_Pages[i] = int.Parse(Console.ReadLine());
               
            }
        }
        public void Display()
        {
            for (int i=0;i<Title.Length; i++)
            {
                Console.WriteLine($"--------------BOOK-{i+1} Details------------------");
                Display( i);
            }
        }
        public void Display(int i)
        {
           
                Console.WriteLine($"Title       ={Title[i]}");
                Console.WriteLine($"ISBN        ={ISBN[i]}");
                Console.WriteLine($"Price       ={Price[i]}");
                Console.WriteLine($"Major Topic ={Major_Area[i]}");
                Console.WriteLine($"Sub Topic   ={Sub_Area[i]}");
                Console.WriteLine($"Total Pages ={NO_of_Pages[i]}");
            
        }
        public void Search(string name)
        {
            bool found = false;
            for(int i = 0; i < Title.Length; i++)
            {
                if (name == Title[i])
                {
                    found = true;
                    Display(i);
                }
                
            }
            if (!found)
            {
               
                    Console.WriteLine("You enter wring title of the Book :");
            }
        }
    }
}
