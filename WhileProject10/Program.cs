using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileProject10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.1, y, max, min;
            max = 1 / (Math.Pow(x, 2) + 1);
            min = 1 / (Math.Pow(x, 2) + 1);
            double sum = 0;
            int k = 0;
            double sr = 0;
            while (x <= 3)
            {
                y = 1 / (Math.Pow(x, 2) + 1);
                Console.WriteLine(" y={0:0.000}  x={1:0.0}", y, x);
                sum = sum + y;
                k++;
                sr = sum / k;
                if (y > max)
                    max = y;
                else
                    min = y;
                x += 0.2;
            }
            Console.WriteLine("Максмимальное значение y={0:0.000}", max);
            Console.WriteLine("Минимальное значение y={0:0.000}", min);
            Console.WriteLine("сумма значений y={0:0.000}", sum);
            Console.WriteLine("колличесвто y={0:0}", k);
            Console.WriteLine("среднее значение y={0:0.000}", sr);
            Console.ReadKey();

        }
    }
}
