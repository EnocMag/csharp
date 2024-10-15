using System;

class Ejs1
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el radio: ");
        string entrada = Console.ReadLine() ?? "Desconocido";

                // Usar int.TryParse para evitar excepciones si la conversión falla
        if (int.TryParse(entrada, out int numero))
        {
            // Llamar al procedimiento con el número ingresado
            ProcesarNumero(numero);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
        }
    }

        // Procedimiento que utiliza el número
    static void ProcesarNumero(int numero)
    {
        decimal perimetro = numero * (3.1416m*2);
        decimal area = 3.1416m * (numero*numero);
        Console.WriteLine($"Perimetro: {perimetro:F1}");
        Console.WriteLine($"Área: {area:F1}");
    }
}