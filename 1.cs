using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti nr de elemente: ");
        int numarElemente = Convert.ToInt32(Console.ReadLine());

        int numerePare = 0;

        for (int i = 0; i < numarElemente; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (EstePar(numar)) numerePare++;            
        }

        Console.WriteLine($"In aceasta secventa, {numerePare} numere sunt pare.");
    }

    static bool EstePar(int numar)
    {
        return numar % 2 == 0;
    }
}