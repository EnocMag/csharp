using System;
using System.Net.WebSockets;

class fizzBuzz
{
    // static void Main(string[] args)
    // {
    //     string f = "fizz";
    //     string b = "buzz";

    //     for (int i = 1; i <= 100; i++)
    //     {

    //         if ((i % 3 == 0) && (i % 5 == 0))
    //         {
    //             Console.WriteLine($"{f}{b}");
    //             continue; 
    //         }

    //         if (i % 3 == 0)
    //         {
    //             Console.WriteLine($"{f}");
    //             continue; 
    //         }

    //         if (i % 5 == 0)
    //         {
    //             Console.WriteLine($"{b}");
    //             continue; 
    //         }
        
    //     Console.WriteLine($"{i}");
    //     }
    // }
    
    //SOLUCION ALTERNATIVA
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            bool dibisibleByThree = i % 3 == 0;
            bool dibisibleByFive = i % 5 == 0;

            if (dibisibleByThree && dibisibleByFive)
            {
                Console.WriteLine($"fizzbuzz");
            } else if (dibisibleByThree){
                Console.WriteLine($"fizz");
            } else if (dibisibleByFive){
                Console.WriteLine($"buzz");
            } else {
                Console.WriteLine($"{i}");
            }
        }
    }
}

