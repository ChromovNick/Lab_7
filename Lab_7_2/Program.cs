using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            Console.Write("L=");
            int L = Convert.ToInt32(Console.ReadLine());
            double S, V;
            Calcs(L, out S, out V);
            Console.WriteLine("Площадь поверхности куба = {0};", S);
            Console.WriteLine("Объем куба = {0};", V);
            Console.Write("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();

        }
        static void Calcs(double L, out double S, out double V)
        {
            S = 6 * (Math.Pow(L,2));
            V = Math.Pow(L,3);
        }
    }
}
