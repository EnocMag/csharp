using System;

class conversionesDeUnidades
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese longitud: ");
        string LongitudCM = Console.ReadLine() ?? "Desconocido";
      

        // Variable para almacenar longitud ingresada 
        int longitudCM = 0;
        
        // Usar int.TryParse para evitar excepciones si la conversión falla
        if (int.TryParse(LongitudCM, out longitudCM))
        {
            // Llamar al procedimiento para convertir a pulgadas
            ProcesarNumero(longitudCM);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa números enteros.");
        }
    }

    static void ProcesarNumero(int longitudCM)
    {
        decimal conversion = longitudCM / 2.54m;
        Console.WriteLine($"{longitudCM} cm = {conversion:F4} in");
    }
}
