using System;
using System.Net.WebSockets;

class Pitagoras
{
    public static void Main(string[] args)
    {
        Console.Write($"Ingrese cateto a: ");
        string CatetoA = Console.ReadLine() ?? "Desconocido";
        Console.Write($"Ingrese cateto b: ");
        string CatetoB = Console.ReadLine() ?? "Desconocido";


        int catetoA = 0;
        int catetoB = 0;

        // Usar int.TryParse para evitar excepciones si la conversión falla
        if (int.TryParse(CatetoA, out catetoA) && int.TryParse(CatetoB, out catetoB))
        {
            // Llamar al procedimiento para calcular el promedio
            ProcesarNumero(catetoA, catetoB);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa números enteros.");
        }
    }

    // Procedimiento que utiliza los números para calcular el promedio
    static void ProcesarNumero(int catetoA, int catetoB)
    {
        catetoA *= catetoA;
        catetoB *= catetoB;
        // double sumaCatetos = (catetoA + catetoB);
        // double hipotenusa = Math.Sqrt(sumaCatetos);
        double hipotenusa = Math.Sqrt(catetoA + catetoB);
        Console.WriteLine($"La hipotenusa es: {hipotenusa:F10}");
    }
}