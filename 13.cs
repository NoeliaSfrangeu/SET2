using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul de elemente: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Introduceti numerele: ");
        int primul = int.Parse(Console.ReadLine());
        int schimb = 0;

        for (int i = 1; i < n; i++)
        {
            int curent = int.Parse(Console.ReadLine());

            if (curent < primul) schimb++;
            primul = curent;
        }

        if (schimb <= 1) Console.WriteLine("Secventa de numere este o secventa crescatoare rotita");
        else Console.WriteLine("Secventa de numere nu este o secventa crescatoare rotita");
    }
}
