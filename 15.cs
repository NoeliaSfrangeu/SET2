using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int lungSecv = Convert.ToInt32(Console.ReadLine());

        int directie = 0;
        int directieNoua = 0;

        Console.Write("Introduceti primul nr: ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < lungSecv - 1; i++)
        {
            Console.Write($"Introduceti nr {i + 2}: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y >= x)
            {
                if (directieNoua != -1 || y == x) directie = 1;
                else
                {
                    directie = 0;
                    break;
                }
            }
            else if (y <= x) directieNoua = -1;
            x = y;
        }

        if (directie != 0) Console.WriteLine("Secventa este bitonica.");
        else Console.WriteLine("Secventa nu este bitonica.");
    }
}
