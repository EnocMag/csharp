// using System;

// class Ordering
// {
//     static void Main(string[] args)
//     {
//         int[] numeros = [5,4,2];

//         process(numeros);
//     }
//     static void process(int[] numeros)
//     {
//         int temp;

//         for (int i = 0; i < numeros.Length - 1; i++)
//         {
            
//             if (numeros[i + 1] < numeros[i])
//             {
//                 temp = numeros[i + 1];
//                 numeros[i + 1] = numeros[i];
//                 numeros[i] = temp;
//             }
//         }
       
//         foreach (int i in numeros)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }

using System;

class Ordering
{
    static void Main()
    {
        // Arreglo con cuatro números
        int[] arreglo = { 8, 3, 5, 1 };

        // Ordenamos el arreglo usando el algoritmo de inserción
        for (int i = 1; i < arreglo.Length; i++)
        {
            int key = arreglo[i];
            int j = i - 1;

            // Desplazamos los elementos de la porción ordenada que son mayores que el 'key' a una posición hacia adelante
            while (j >= 0 && arreglo[j] > key)
            {
                arreglo[j + 1] = arreglo[j];
                j--;
            }

            // Colocamos el 'key' en su lugar correspondiente
            arreglo[j + 1] = key;
        }

        // Imprimimos el arreglo ordenado
        Console.WriteLine("Arreglo ordenado:");
        foreach (int numero in arreglo)
        {
            Console.WriteLine(numero);
        }
    }
}
