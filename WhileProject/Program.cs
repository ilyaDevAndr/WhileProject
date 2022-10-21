using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -2;
            Double y;
            while (x <= 2)
            {
                y = Math.Pow(x, 2) + 1 / Math.Pow(x, 2);
                Console.WriteLine(" y={0:0.0}  x={1:0.0}", y, x);
                x += 0.5;
            }
            Console.ReadKey();

        }
    }
}
