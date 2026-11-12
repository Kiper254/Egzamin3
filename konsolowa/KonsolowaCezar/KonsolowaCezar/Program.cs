using System;

namespace KonsolowaCezar
{
    internal class Program
    {
        /*
        nazwa funkcji: SzyfrujCezarem
        opis funkcji: Szyfruje tekst jawny szyfrem Cezara, przesuwajac male litery alfabetu lacinskiego o podany klucz. Spacje pozostawia bez zmian.
        parametry: tekstJawny - tekst przeznaczony do zaszyfrowania; klucz - liczba calkowita okreslajaca przesuniecie
        zwracany typ i opis: string - tekst zaszyfrowany szyfrem Cezara
        autor: numer zdajacego
        */
        public static string SzyfrujCezarem(string tekstJawny, int klucz)
        {
            string tekstZaszyfrowany = "";
            int przesuniecie = klucz % 26;

            for (int i = 0; i < tekstJawny.Length; i++)
            {
                char znak = tekstJawny[i];

                if (znak >= 'a' && znak <= 'z')
                {
                    int numerZnaku = znak - 'a';
                    int nowyNumerZnaku = (numerZnaku + przesuniecie) % 26;

                    if (nowyNumerZnaku < 0)
                    {
                        nowyNumerZnaku += 26;
                    }

                    tekstZaszyfrowany += (char)('a' + nowyNumerZnaku);
                }
                else
                {
                    tekstZaszyfrowany += znak;
                }
            }

            return tekstZaszyfrowany;
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj tekst jawny: ");
            string tekstJawny = Console.ReadLine();

            Console.Write("Podaj klucz: ");
            string wpisanyKlucz = Console.ReadLine();

            int klucz;

            if (!int.TryParse(wpisanyKlucz, out klucz))
            {
                klucz = 0;
            }

            string tekstZaszyfrowany = SzyfrujCezarem(tekstJawny, klucz);

            Console.WriteLine("Tekst zaszyfrowany: " + tekstZaszyfrowany);
            Console.WriteLine("Nacisnij dowolny klawisz, aby zakonczyc.");
            Console.ReadKey();
        }
    }
}