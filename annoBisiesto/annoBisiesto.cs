using System;

class annoBisiesto
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese año: ");
        string Anno = Console.ReadLine() ?? "Desconocido";

        int anno;

        if (int.TryParse(Anno, out anno))
        {
            proceso(anno);
        }
        else 
        {
            Console.WriteLine("Entrada no valida, por favor ingresa un número entero");
        }
    }
    static void proceso(int anno)
    {
        bool bisiesto = false;

        
    }
}