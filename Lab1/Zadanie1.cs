using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Zadania
{
    internal class Zadanie1
    {
        public void Run()
        {
            Console.WriteLine("Program oblicza deltę i pierwiastki trójmianu kwadratowego");
            Console.WriteLine("Podaj współczynniki ax² + bx + c = 0");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe!");
                return;
            }

            double delta = (b * b) - (4 * a * c);
            Console.WriteLine($"Delta = {delta}");

            if (delta < 0)
            {
                Console.WriteLine("Brak pierwiastków rzeczywistych");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Jedno rozwiązanie: x = {x:F2}");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Dwa rozwiązania: x1 = {x1:F2}, x2 = {x2:F2}");
            }
        }
    }
}
