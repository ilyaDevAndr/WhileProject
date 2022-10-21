using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -1;
            Double y;
            while (x <= 2)
            {
                y = Math.Exp(-x) - x;
                Console.WriteLine(" y={0:0.00}  x={1:0.00}", y, x);
                x += 0.2;
            }
            Console.ReadKey();

        }
    }
}
