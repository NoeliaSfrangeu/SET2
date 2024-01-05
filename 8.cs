using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti ce nr vreti sa aflati din sirul lui Fibonacci: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int fibonacciN = Fibonacci(n);

        Console.WriteLine($"Al {n}-lea nr din sirul lui Fibonacci este: {fibonacciN}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1) return n;

        int fibNMinus1 = 1, fibNMinus2 = 0;

        for (int i = 2; i <= n; i++)
        {
            (fibNMinus1, fibNMinus2) = (fibNMinus1 + fibNMinus2, fibNMinus1);
        }

        return fibNMinus1;
    }
}
