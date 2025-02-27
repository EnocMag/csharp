using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Por favor ingresa tu nombre: ");
         string nombre = Console.ReadLine() ?? "Desconocido";

        Saludar(nombre);
    }

    static void Saludar(string nombre)
    {
        Console.WriteLine($"Hola, {nombre}! Bienvenido :)");
    }
}
