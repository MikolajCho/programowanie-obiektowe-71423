using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Zadania
{
    internal class Zadanie2
    {
        public void Run()
        {
            double[] liczby = new double[10];

            Console.WriteLine("Wprowadź 10 liczb:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Liczba {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double iloczyn = 1;
            double min = liczby[0];
            double max = liczby[0];

            foreach (double liczba in liczby)
            {
                suma += liczba;
                iloczyn *= liczba;
                if (liczba < min) min = liczba;
                if (liczba > max) max = liczba;
            }

            double srednia = suma / liczby.Length;

            Console.WriteLine("\nWyniki:");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Iloczyn: {iloczyn}");
            Console.WriteLine($"Średnia: {srednia:F2}");
            Console.WriteLine($"Wartość minimalna: {min}");
            Console.WriteLine($"Wartość maksymalna: {max}");
        }
    }
}

