using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для решения уравнения вида k*x+b = 0 введите значения коэффициентов k и b:");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Linear linear = new Linear (k, b);
            Console.WriteLine(linear.Root());
            Console.ReadKey(); 
        }
    }
}
