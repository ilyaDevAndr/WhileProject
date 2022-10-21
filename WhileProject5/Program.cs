using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -2;
            Double y;
            while (x <= 4)
            {
                y = Math.Sqrt(x / x - 1);
                Console.WriteLine(" y={0:0.00}  x={1:0.00}", y, x);
                x += 0.5;
                
            }
            Console.ReadKey();
        }
    }
}
       

