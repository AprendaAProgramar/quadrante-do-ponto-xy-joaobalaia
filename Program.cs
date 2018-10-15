using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.WriteLine("digite um valor para o x");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite um valor para o y");
            y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("esta no 1 quadrante");
            else
            
                if (x > 0 && y < 0)
                    Console.WriteLine("esta no 4 quadrante");
            
            else
            
                if (x<0 && y >0)
                    Console.WriteLine("esta no 2 quadrante");
            
            else 
            Console.WriteLine("esta no 3 quadrante");






        }
    }
}
