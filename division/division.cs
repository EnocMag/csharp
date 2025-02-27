using System;
// Escriba un programa que pida dos números enteros y que calcule la división, indicando si la división es exacta o no.
class Division
{
    static void Main(string[] args)
    {
        Console.Write($"Dividendo: ");
        string Dividendo = Console.ReadLine() ?? "Desconocido";
        Console.Write("Divisor: ");
        string Divisor = Console.ReadLine() ?? "Desconocido";

        int dividendo, divisor;

        if (int.TryParse(Dividendo, out dividendo) && int.TryParse(Divisor, out divisor))
        {
            procesarDivision(dividendo, divisor);
        }
        else {
            Console.WriteLine("Entrada no valida, por favor ingresa un número entero");
        }
    }
    static void procesarDivision(int dividendo, int divisor)
    {
        int cociente = dividendo / divisor;
        int resto = dividendo % divisor;
        
        if (resto == 0)
        {
            Console.WriteLine($"La división es exacta \nCociente: {cociente} \nResto: {resto}");
        }
        else{
            Console.WriteLine($"La división no es exacta \nCociente: {cociente} \nResto: {resto}");
        }
    }
}