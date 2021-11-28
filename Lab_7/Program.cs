using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            Console.Write("А1=");
            int А1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("В1=");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("C1=");
            int C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника");
            Console.Write("А2=");
            int А2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("В2=");
            int B2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("C2=");
            int C2 = Convert.ToInt32(Console.ReadLine());
            double P1, P2, S1, S2, p1, p2;
            Calcs (А1, А2, B1, C1, C2, B2, out S1, out P1, out S2, out P2,out p1, out p2);
            Console.WriteLine(S1>S2 ? "Площадь первого треугольника больше S1={0}" : "Площадь второго треугольника больше S2={1}", S1,S2);
            Console.ReadKey();
            Console.Write("Для завершения программы нажмите любую клавишу");
        }
        static void Calcs (double A1, double A2, double B1, double B2, double C1, double C2, out double S1, out double S2, out double P1, out double P2, out double p1, out double p2)
        {
            P1 = A1 + B1 + C1;
            p1 = P1 / 2;
            S1 = Math.Sqrt(p1 * Math.Abs(p1 - A1) * Math.Abs(p1 - B1) * Math.Abs(p1 - C1));
            P2 = A2 + B2 + C2;
            p2 = P2 / 2;
            S2 = Math.Sqrt(p2 * Math.Abs(p2 - A2) * Math.Abs(p2 - B2) * Math.Abs(p2 - C2));
        }
    }
}