// using System;
// class Fibonacci
// {
//     static void Main(string[] args)
//     {
//         int previous = 0;
//         int current = 1;
//         int fibonacciNumber;
//         int n = 50;

//         for (int i = 0; i <= n; i++)
//         {
//             if (i == 0)
//             {
//                 fibonacciNumber = 0;
//             }
//             else if (i == 1)
//             {  
//                 fibonacciNumber = 1;
//             }
//             else if (i == 2)
//             {
//                 fibonacciNumber = 1;
//             }
//             else
//             {
//                 fibonacciNumber = previous + current;
//                 previous = current;
//                 current = fibonacciNumber;
//             }
//             Console.WriteLine($"Numero {i} finbonacci: {fibonacciNumber}");
//         }
//     }
// }

//CORRECCION
// using System;
// class Fibonacci
// {
//     static void Main(string[] args)
//     {
//         long previous = 0;  // El primer número de Fibonacci
//         long current = 1;   // El segundo número de Fibonacci
//         long fibonacciNumber;

//         int n = 50; // Número máximo de términos de Fibonacci a mostrar

//         for (int i = 0; i <= 50; i++)
//         {
//             if (i == 0)
//             {
//                 fibonacciNumber = 0;
//             }
//             else if (i == 1)
//             {
//                 fibonacciNumber = 1;
//             }
//             else
//             {
//                 fibonacciNumber = previous + current;
//                 previous = current;
//                 current = fibonacciNumber;
//             }
            
//             Console.WriteLine($"Número {i} en Fibonacci: {fibonacciNumber}");
//         }
//     }
// }

// MoureDev
using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        long n0 = 0;  // El primer número de Fibonacci
        long n1 = 1;   // El segundo número de Fibonacci

        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine($"{n0}");
            
            long fib = n0 + n1;
            n0 = n1;
            n1 = fib;
        }
    }
}