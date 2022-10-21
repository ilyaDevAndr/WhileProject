using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -1, y, min;
            min = x + 1 / x;
            while (x <= 3)
            {
                y = x + 1 / x;
                Console.WriteLine(" y={0:0.0}  x={1:0.0}", y, x);
                x += 0.5;
                if (y < min)
                    min = y;
            }
            Console.WriteLine("Минимальное значение y={0:.00}", min);
            Console.ReadKey();

        }
    }
}
