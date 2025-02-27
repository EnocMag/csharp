using System;
class LongestWord
{
    static void Main(string[] args)
    {
        Console.Write($"Palabra 1: ");
        string palabra1 = Console.ReadLine() ?? "Desconocido";
        
        Console.Write($"Palabra 2: ");
        string palabra2 = Console.ReadLine() ?? "Desconocido";
        
        int diferencia;

        if (palabra1.Length == palabra2.Length)
        {
            Console.WriteLine($"Las dos palabras tienen el mismo largo");
        }
        else if (palabra1.Length > palabra2.Length)
        {
            diferencia = palabra1.Length - palabra2.Length;
            Console.WriteLine($"La palabra {palabra1} tiene {diferencia} letras mas que {palabra2}");
        }
        else
        {
            diferencia = palabra2.Length - palabra1.Length;
            Console.WriteLine($"La palabra {palabra2} tiene {diferencia} letras mas que {palabra1}");
        }
    }
}