using System;
using System.Diagnostics;
class HowManyDigits
{
    static void Main(string[] args)
    {
        //Calcular la cantidad de digitos de una valor entregado solo utilizando operaciones matematicas
        Console.Write($"Calcular la cantidad de digitos de: ");
        if (!int.TryParse(Console.ReadLine(), out int digits)){
            Console.WriteLine($"Valor ingresado incorrecto, ingresa solo numeros enteros");
            return;
        }
        process(digits);
    }
    static void process(int digits)
    {
        int cont = 0;
        do{
            digits /= 10;
            cont++;
        }while (digits > 0);

        Console.WriteLine($"Numero de digitos: {cont}");
    }
}