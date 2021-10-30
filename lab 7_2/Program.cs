using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            calcAreaVol(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба равна {0,4:f2}; объем куба равен {1,4:f2}.", S, V);
            Console.ReadKey();
        }
        static void calcAreaVol(int a, out double S, out double V)
        {
            S = a * a * 6;
            V = a * a * a;
        }
    }
}

