using System;

class Program
{
    static void Main()
    {
        try
        {
            string sciezkaDoPliku = "plik.txt"; // wpisz ścieżkę do pliku

            if (!System.IO.File.Exists(sciezkaDoPliku))
            {
                Console.WriteLine("Plik nie istnieje.");
                return;
            }

            using (System.IO.StreamReader czytnik = new System.IO.StreamReader(sciezkaDoPliku))
            {
                string? linia;
                while ((linia = czytnik.ReadLine()) != null)
                {
                    string odwroconaLinia = OdwrocString(linia);
                    Console.WriteLine(odwroconaLinia);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }

    static string OdwrocString(string str)
    {
        char[] tablicaZnakow = str.ToCharArray();
        Array.Reverse(tablicaZnakow);
        return new string(tablicaZnakow);
    }
}
