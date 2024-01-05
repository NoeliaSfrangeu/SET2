using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungimeSecventa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti nr cautat: ");
        int numarCautat = Convert.ToInt32(Console.ReadLine());

        int pozitie = -1;

        for (int i = 0; i < lungimeSecventa; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (numar == numarCautat)
            {
                pozitie = i;
                break;
            }
        }

        Console.WriteLine($"Nr {numarCautat} este pe pozitia {pozitie}");
    }
}
