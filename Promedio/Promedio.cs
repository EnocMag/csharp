using System;

class Promedio
{
    public static void Main(string[] args)
    {
        Console.Write("Primera nota: ");
        string Nota1 = Console.ReadLine() ?? "Desconocido";
        Console.Write("Segunda nota: ");
        string Nota2 = Console.ReadLine() ?? "Desconocido";
        Console.Write("Segunda nota: ");
        string Nota3 = Console.ReadLine() ?? "Desconocido";
        Console.Write("Segunda nota: ");
        string Nota4 = Console.ReadLine() ?? "Desconocido";

        // Variables para almacenar las notas
        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int nota4 = 0;

        // Usar int.TryParse para evitar excepciones si la conversión falla
        if (int.TryParse(Nota1, out nota1) && int.TryParse(Nota2, out nota2) && int.TryParse(Nota3, out nota3) && int.TryParse(Nota4, out nota4))
        {
            // Llamar al procedimiento para calcular el promedio
            ProcesarNumero(nota1, nota2, nota3, nota4);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa números enteros.");
        }
    }

    // Procedimiento que utiliza los números para calcular el promedio
    static void ProcesarNumero(int nota1, int nota2, int nota3, int nota4)
    {
        decimal prom = (nota1 + nota2 + nota3 + nota4) / 4m; // Usar 2m para asegurar que se use decimal
        Console.WriteLine($"\nPromedio: \t{prom:F2}");
    }
}
