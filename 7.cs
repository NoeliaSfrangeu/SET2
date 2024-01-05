using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea sec: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        int max = int.MinValue;
        int min = int.MaxValue; 

        for (int i = 0; i < lungSecv; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (numar > max) max = numar;            
            if (numar < min) min = numar;           
        }

        Console.WriteLine($"Cea mai mare valoare este: {max}");
        Console.WriteLine($"Cea mai mică valoare este: {min}");
    }
}
