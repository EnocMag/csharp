using System;

class parteDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        string NumeroReal = Console.ReadLine() ?? "Desconocido";

        decimal numeroReal = 0;

        if (decimal.TryParse(NumeroReal, out numeroReal))   
        {   
            ProcesarNumero(numeroReal);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa números enteros.");
        }
    }
    static void ProcesarNumero(decimal numeroReal)
    {
        
        decimal parteDecimal =  numeroReal - Math.Floor(numeroReal);
        decimal parteDecimalNegativos = ((int)numeroReal) - numeroReal;

        if (numeroReal > 0)
        {
            Console.WriteLine($"La parte decimal es: {parteDecimal}");
        }
        else
        {
            Console.WriteLine($"La parte decimal es: {parteDecimalNegativos}");
        }
    }
}