using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        bool esteMonotona = true;
        int numarAnterior = int.MinValue;

        for (int i = 0; i < lungSecv && esteMonotona; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            esteMonotona = int.TryParse(Console.ReadLine(), out int numar) && numar >= numarAnterior;
            numarAnterior = numar;
        }

        Console.WriteLine(esteMonotona ? "secventa este monotona." : "secventa nu este monotona.");
    }
}
