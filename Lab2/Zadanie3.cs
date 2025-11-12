using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Zadania
{
    internal class Zadanie3
    {
        public void Run()
        {
            Student student = new Student("Anna", "Nowak");
            student.DodajOcene(5);
            student.DodajOcene(4);
            student.DodajOcene(3);
            student.DodajOcene(5);

            Console.WriteLine($"Student: {student.Imie} {student.Nazwisko}");
            Console.WriteLine($"Średnia ocen: {student.SredniaOcen:F2}");
        }
    }

    public class Student
    {
        private int[] oceny;
        private int liczbaOcen;

        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public double SredniaOcen
        {
            get
            {
                if (liczbaOcen == 0) return 0;

                int suma = 0;
                for (int i = 0; i < liczbaOcen; i++)
                {
                    suma += oceny[i];
                }
                return (double)suma / liczbaOcen;
            }
        }

        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            oceny = new int[10];
            liczbaOcen = 0;
        }

        public void DodajOcene(int ocena)
        {
            if (liczbaOcen < oceny.Length)
            {
                oceny[liczbaOcen] = ocena;
                liczbaOcen++;
                Console.WriteLine($"Dodano ocenę: {ocena}");
            }
            else
            {
                Console.WriteLine("Nie można dodać więcej ocen - tablica pełna");
            }
        }
    }
}
