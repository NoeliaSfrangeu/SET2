using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        int maxConsecutiveEgale = 1;
        int consecutiveEgaleCurent = 1;

        Console.Write("Introduceti nr 1: ");
        int nrAnterior = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= lungSecv; i++)
        {
            Console.Write($"Introduceti nr {i}: ");
            int nrCurent = Convert.ToInt32(Console.ReadLine());

            if (nrCurent == nrAnterior)
            {
                consecutiveEgaleCurent++;
                if (consecutiveEgaleCurent > maxConsecutiveEgale)
                {
                    maxConsecutiveEgale = consecutiveEgaleCurent;
                }
            }
            else
            {
                consecutiveEgaleCurent = 1;
            }

            nrAnterior = nrCurent;
        }

        Console.WriteLine($"Nr maxim de numere consecutive egale este: {maxConsecutiveEgale}");
    }
}
