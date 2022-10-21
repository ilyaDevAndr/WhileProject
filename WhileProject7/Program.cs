using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Double y;
            while (x <= 2 * Math.PI)
            {
                y = Math.Tan(x);
                Console.WriteLine(" y={0:0.0}  x={1:0.0}", y, x);
                x += Math.PI / 12;
            }
            Console.ReadKey();

        }
    }
}
