using System;

class NumeroPrimo
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número y comprueba si es primo: ");
        string TestNum = Console.ReadLine() ?? "Desconocido";

        int testNum = 0;

        if (int.TryParse(TestNum, out testNum))
        {
            process(testNum);
        }
        else
        {
            Console.WriteLine("Entrada no válida, por favor ingresa un número entero");
        }

    // Listar los números primos hasta 100
        primosAlCien();
    }

    static void process(int testNum)
    {
        bool primo = true;

        if (testNum <= 1)
        {
            primo = false;
        }
        else if (testNum == 2)
        {
            primo = true;
        }
        else
        {
            int n = (int)Math.Sqrt(testNum); 

            for (int i = 2; i <= n; i++)  // Cambié double por int
            {
                if (testNum % i == 0)
                {
                    primo = false;
                    break; // No necesitamos seguir buscando más divisores
                }
            }
        }

        message(primo, testNum); // Mostrar el resultado
    }

    static void message(bool primo, int testNum)
    {
        if (primo)
        {
            Console.WriteLine($"{testNum} es número primo");
        }
        else
        {
            Console.WriteLine($"{testNum} no es número primo");
        }
    }

    static void primosAlCien()
    {
        Console.WriteLine("\nNúmeros primos hasta 100:");

        for (int x = 2; x <= 100; x++) // Empezamos en 2, ya que los números menores que 2 no son primos
        {
            bool esPrimo = true; // Asumimos que el número es primo

            // Verificar divisibilidad
            int n = (int)Math.Sqrt(x); // Solo necesitamos verificar hasta la raíz cuadrada de x

            for (int i = 2; i <= n; i++)
            {
                if (x % i == 0) // Si encontramos un divisor, no es primo
                {
                    esPrimo = false;
                    break; // Si ya encontramos un divisor, no necesitamos seguir buscando
                }
            }

            if (esPrimo)
            {
                Console.Write($"{x}, "); // Si es primo, lo imprimimos
            }
        }
    }
}

// using System;

// class NumeroPrimo
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Ingresa un número y comprueba si es primo: ");
//         string TestNum = Console.ReadLine() ?? "Desconocido";

//         int testNum = 0;

//         if (int.TryParse(TestNum, out testNum))
//         {
//             process(testNum);
//         }
//         else
//         {
//             Console.WriteLine("Entrada no valida, por favor ingresa un número entero");
//         }
//     }
//     static void process(int testNum)
//     {
//         bool primo = false;

//         if (testNum <= 1)
//         {
//             primo = false;
//             message(primo, testNum);
//             return;
//         }
        
//         if (testNum == 2)
//         {
//             primo = true;
//             message(primo, testNum);
//             return;
//         }

//         int n = (int)Math.Sqrt(testNum); 

//         for (int i = 2; i <= n; i++)
//         {
//             if (testNum % i == 0)
//             {
//                 primo = false;
//                 message(primo, testNum);
//                 return;
//             }
//         }

//         primo = true;
//         message(primo, testNum);

//         static void message(bool primo, int testNum)
//         {
//             if (primo == true)
//             {
//                 Console.WriteLine($"{testNum} es número primo");
//             }
//             else
//             {
//                 Console.WriteLine($"{testNum} no es número primo");
//             }
//         }
        

//         static void primosAlCien()
//         {
//             for (int x = 2; x <= 100; x++) // Empezamos en 2, ya que los números menores que 2 no son primos
//             {
//                 bool esPrimo = true; // Asumimos que el número es primo

//                 // Verificar divisibilidad
//                 int n = (int)Math.Sqrt(x); // Solo necesitamos verificar hasta la raíz cuadrada de x

//                 for (int i = 2; i <= n; i++)
//                 {
//                     if (x % i == 0) // Si encontramos un divisor, no es primo
//                     {
//                         esPrimo = false;
//                         break; // Si ya encontramos un divisor, no necesitamos seguir buscando
//                     }
//                 }

//                 if (esPrimo)
//                 {
//                     Console.WriteLine($"{x}"); // Si es primo, lo imprimimos
//                 }
//             }
//         }
//         primosAlCien();
//     }
// }