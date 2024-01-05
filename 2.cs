using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti nr de elemente: ");
        int lungimeSecventa = Convert.ToInt32(Console.ReadLine());

        int numereNegative = 0;
        int numereZero = 0;
        int numerePozitive = 0;

        for (int i = 0; i < lungimeSecventa; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (numar < 0) numereNegative++;            
            else if (numar == 0) numereZero++;            
            else numerePozitive++;
            
        }

        Console.WriteLine($"{numereNegative} nr negative, {numereZero} nr egal cu zero, {numerePozitive} nr pozitive.");
    }
}
