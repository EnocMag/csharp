using System;

class queNota
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese nota certamen 1: ");
        string Certamen1 = Console.ReadLine() ?? "Desconocido";
        Console.Write("Ingrese nota certamen 2: ");
        string Certamen2 = Console.ReadLine() ?? "Desconocido";
        Console.Write("Ingrese nota laboratorio: ");
        string Laboratorio = Console.ReadLine() ?? "Desconocido";

        int certamen1;
        int certamen2;
        int laboratorio;

        if(int.TryParse(Certamen1, out certamen1) && int.TryParse(Certamen2, out certamen2) && int.TryParse(Laboratorio, out laboratorio))
        {
            proceso(certamen1, certamen2, laboratorio);
        }
        else
        {
            Console.WriteLine($"Entrada no valida, por favor ingresa numeros enteros");
        }

        static void proceso(int certamen1, int certamen2, int laboratorio)
        {
            decimal certamen3;
            certamen3 = (3 * ((60 - 0.3m * laboratorio) / 0.7m)) - certamen1 - certamen2;

            Console.WriteLine($"Necesitas una nota {certamen3:f2} en el certamen 3");
        }
    }
}