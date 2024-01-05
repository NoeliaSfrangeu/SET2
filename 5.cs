using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secvntei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        int nrEgaleCuPozitie = 0;

        for (int i = 0; i < lungSecv; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int nr = Convert.ToInt32(Console.ReadLine());

            if (nr == i)
            {
                nrEgaleCuPozitie++;
            }
        }

        Console.WriteLine($"{nrEgaleCuPozitie} elemente sunt egale cu pozitia pe care sunt");
    }
}
