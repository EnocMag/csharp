using System;

class invertedNum
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese número: ");
        string Numero = Console.ReadLine() ?? "Desconocido";
      

        // Variable para almacenar longitud ingresada 
        int numero = 0;
        
        // Usar int.TryParse para evitar excepciones si la conversión falla
        if (int.TryParse(Numero, out numero))
        {
            // Llamar al procedimiento para convertir a pulgadas
            ProcesarNumero(numero);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa números enteros.");
        }
    }

    static void ProcesarNumero(int numero)
    {
        string numeroStr = numero.ToString(); //Convierte el número ingrezado en un string
        char[] arreglo = numeroStr.ToCharArray(); //Convierte la cadena en un arreglo de carecteres (de tipo char[])
        
        Array.Reverse(arreglo); //Llamada al metodo .Reverse de la calse Array para invertir el orden del arreglo
        
        string numeroStrInvertido = new string(arreglo); //vuelve a convertir el arreglo un una cadena tipo string

        int numeroInvertido = int.Parse(numeroStrInvertido); //convierte la cadena tipo string en un int

        Console.WriteLine($"{numeroInvertido}");
    }
}
