using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Fraction
    {
        private int Dividend;
        private int Divisor;

        public Fraction(int Dividend,int Divisor)
        {
            this.Dividend = Dividend;
            this.Divisor = Divisor; 
        }
        public void Display()
        {
            Console.WriteLine($" {Dividend} / {Divisor}");
            
        }
    }
    
}
