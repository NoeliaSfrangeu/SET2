using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        bool suntInOrdineCrescatoare = true;

        int nrAnte = int.MinValue;

        for (int i = 0; i < lungSecv; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (numar <= nrAnte)
            {
                suntInOrdineCrescatoare = false;
                break; 
            }

            nrAnte = numar;
        }

        if (suntInOrdineCrescatoare)
        {
            Console.WriteLine("Nr din secventa sunt in ordine crescatoare.");
        }
        else
        {
            Console.WriteLine("Nr din secventa nu sunt in ordine crescatoare.");
        }
    }
}
