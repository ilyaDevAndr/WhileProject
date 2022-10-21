using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -5;
            Double y;
            while (x <= 5)
            {
                y = Math.Sqrt(x + 1);
                Console.WriteLine(" y={0:0.00}  x={1:0.00}", y, x);
                x += 1.5;
            }
            Console.ReadKey();

        }
    }
}
