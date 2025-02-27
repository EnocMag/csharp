using System;

class determinarPar
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        string N = Console.ReadLine() ?? "Desconocido";

        int n = 0;

        if(int.TryParse(N, out n))
        {
            proceso(n);
        }
        else
        {
            Console.WriteLine("Entrada no valida, por favor ingresa un número entero");
        }

        static void  proceso(int n)
        {
            if((n % 2) == 0)
            {
                Console.WriteLine($"Su número es par");
            }
            else
            {
                Console.WriteLine("Su número es inpar");
            }
        }
    }
}