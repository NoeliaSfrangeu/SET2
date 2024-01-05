using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti un numar n: ");
        int nr = int.Parse(Console.ReadLine());

        Console.WriteLine($"Introduceti numerele: ");
        int primul = int.Parse(Console.ReadLine());
        int schimb = 0, schimb2 = 0;

        for (int i = 1; i < nr; i++)
        {
            int currentNr = int.Parse(Console.ReadLine());

            if (currentNr != primul)
            {
                if ((currentNr < primul && schimb++ > 0) || (currentNr > primul && schimb2++ > 0))
                {
                    Console.WriteLine("Secventa de numere nu este monotona rotita");
                    return;
                }
            }

            primul = currentNr;
        }

        Console.WriteLine("Secventa de numere este monotona rotita");
    }
}
