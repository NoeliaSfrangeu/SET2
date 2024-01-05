using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti secventa de 0 si 1: ");
        string secventa = Console.ReadLine();

        bool rezultat = VerificaSecventaParanteze(secventa, out int nivelMaxim);

        Console.WriteLine($"Secventa introdusa: {secventa}");
        Console.WriteLine($"Este corecta: {rezultat}, Nivelul de incuibare este: {nivelMaxim}");
    }

    static bool VerificaSecventaParanteze(string secventa, out int nivelMaxim)
    {
        int nivelCurent = 0;
        nivelMaxim = 0;

        foreach (char caracter in secventa)
        {
            if (caracter == '0')
            {
                nivelCurent++;
                nivelMaxim = Math.Max(nivelMaxim, nivelCurent);
            }
            else if (caracter == '1')
            {
                nivelCurent--;
                if (nivelCurent < 0) return false;
            }
            else return false;
        }

        return nivelCurent == 0;
    }
}
