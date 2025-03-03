using System;
using System.Runtime.InteropServices;
class LetterOrNumber
{
    static void Main(string[] args)
    {
        Console.Write($"Ingrese caracter: ");


        if (char.TryParse(Console.ReadLine(), out char myChar))
        {
            if (char.IsLetter(myChar))
            {
                if (char.IsLower(myChar))
                {
                    Console.WriteLine($"{myChar} es una letra minúscula");
                }
                else
                {
                    Console.WriteLine($"{myChar} es una letra mayúscula");
                }
            }
            else if (char.IsDigit(myChar))
            {
                Console.WriteLine($"{myChar} es un número.");
            }
            else
            {
                Console.WriteLine($"{myChar} es un símbolo.");
            }
        }
        else
        {
            Console.WriteLine($"Ingresa solo un caracter");
        }
    }
}