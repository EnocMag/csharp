// using System;

// class Anagrama
// {
//     static void Main(string[] args)
//     {
//         Console.Write($"Introduce la primer palabra: ");
//         string palabra1 = Console.ReadLine() ?? "Desconocido";
//         Console.Write($"Introduce la segunda palabra: ");
//         string palabra2 = Console.ReadLine() ?? "Desconocido";

//         // Convertir las palabras a arreglos de caracteres
//         char[] arreglo1 = palabra1.ToCharArray();
//         char[] arreglo2 = palabra2.ToCharArray();

//         // Si las longitudes son diferentes, no pueden ser anagramas
//         if (arreglo1.Length != arreglo2.Length)
//         {
//             Console.WriteLine($"La palabra '{palabra1}' no es anagrama de '{palabra2}'");
//         }
//         else
//         {
//             bool esAnagrama = true;

//             // Recorrer cada carácter de arreglo1
//             for (int i = 0; i < arreglo1.Length; i++)
//             {
//                 bool encontrado = false;

//                 // Comparar con cada carácter de arreglo2
//                 for (int j = 0; j < arreglo2.Length; j++)
//                 {
//                     // Si encontramos un carácter coincidente, lo marcamos y lo "eliminamos" de arreglo2
//                     if (arreglo1[i] == arreglo2[j])
//                     {
//                         arreglo2[j] = '\0';  // Marcamos el carácter como 'eliminado'
//                         encontrado = true;
//                         break;  // Salimos del bucle interno
//                     }
//                 }

//                 // Si no encontramos una coincidencia, no son anagramas
//                 if (!encontrado)
//                 {
//                     esAnagrama = false;
//                     break;
//                 }
//             }

//             if (esAnagrama)
//             {
//                 Console.WriteLine($"La palabra '{palabra1}' es anagrama de '{palabra2}'");
//             }
//             else
//             {
//                 Console.WriteLine($"La palabra '{palabra1}' no es anagrama de '{palabra2}'");
//             }
//         }
//     }
// }

using System;
using System.Linq;

class Anagrama
{
    static void Main(string[] args)
    {
        Console.Write($"Introduce la primer palabra: ");
        string palabra1 = Console.ReadLine() ?? "Desconocido";
        Console.Write($"Introduce la segunda palabra: ");
        string palabra2 = Console.ReadLine() ?? "Desconocido";

        // Convertir las palabras a arreglos de caracteres
        char[] arreglo1 = palabra1.ToCharArray();
        char[] arreglo2 = palabra2.ToCharArray();

        // Si las longitudes son diferentes, no pueden ser anagramas
        if (arreglo1.Length != arreglo2.Length)
        {
            impNoAnagrama(palabra1, palabra2);
        }
        else
        {
            // Ordenar los arreglos de caracteres
            var arreglo1Ordenado = arreglo1.OrderBy(c => c).ToArray();
            var arreglo2Ordenado = arreglo2.OrderBy(c => c).ToArray();

            Console.WriteLine($"{arreglo1}");
            

            // Comparar los arreglos ordenados
            if (arreglo1Ordenado.SequenceEqual(arreglo2Ordenado))
            {
                impNoAnagrama(palabra1, palabra2);
            }
            else
            {
                impSiAnagrama(palabra1, palabra2);
            }
        }
        static void impSiAnagrama(string palabra1, string palabra2)
        {
            Console.WriteLine($"La palabra '{palabra1}' es anagrama de '{palabra2}'");
        }
        static void impNoAnagrama(string palabra1, string palabra2)
        {
            Console.WriteLine($"La palabra '{palabra1}' no es anagrama de '{palabra2}'");
        }
    }
}