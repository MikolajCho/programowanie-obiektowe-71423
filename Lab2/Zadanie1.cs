using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Zadania
{
    internal class Zadanie1
    {
        public void Run()
        {
            try
            {
                Osoba osoba1 = new Osoba("Jan", "Kowalski", 25);
                osoba1.WyswietlInformacje();

                Osoba osoba2 = new Osoba("A", "Nowak", 30);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            try
            {
                Osoba osoba3 = new Osoba("Anna", "B", -5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }

    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get { return imie; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Imię musi mieć co najmniej 2 znaki");
                imie = value;
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki");
                nazwisko = value;
            }
        }

        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Wiek musi być liczbą dodatnią");
                wiek = value;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
        }
    }
}
