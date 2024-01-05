using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti cate elemente are secventa: ");
        int nr = int.Parse(Console.ReadLine());

        Console.WriteLine($"Introduceti numerele: ");
        int x = int.Parse(Console.ReadLine());
        int schimb = 0;
        bool esteBitonicaRotita = false;

        for (int i = 1; i < nr; i++)
        {
            int y = int.Parse(Console.ReadLine());

            if (y > x)
            {
                if (!esteBitonicaRotita)
                {
                    schimb++;
                    esteBitonicaRotita = true;
                }
            }
            else if (y < x)
            {
                if (!esteBitonicaRotita)
                {
                    schimb++;
                    esteBitonicaRotita = true;
                }
            }

            x = y;
        }

        if (schimb <= 2) Console.WriteLine("Secventa de numere este bitonica rotita");
        else Console.WriteLine("Secventa de numere nu este bitonica rotita");

    }
}
