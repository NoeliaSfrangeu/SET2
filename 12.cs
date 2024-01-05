using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());
        int grupuriConsecutive = 0;
        bool inGrup = false;

        for (int i = 0; i < lungSecv; i++)
        {
            Console.Write($"Introduceti nr {i + 1}: ");
            int nr = Convert.ToInt32(Console.ReadLine());

            if (nr != 0)
            {
                if (!inGrup)
                {
                    inGrup = true;
                    grupuriConsecutive++;
                }
            }
            else
            {
                inGrup = false;
            }
        }

        Console.WriteLine($"Nr de grupuri consecutive diferite de zero este: {grupuriConsecutive}");
    }
}
