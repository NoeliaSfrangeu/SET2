using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        double sumaInverselor = 0;

        for (int i = 0; i < lungSecv; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            double nr = Convert.ToDouble(Console.ReadLine());

            sumaInverselor += nr != 0 ? 1 / nr : 0;
        }

        Console.WriteLine($"Suma inverselor este: {sumaInverselor}");
    }
}
