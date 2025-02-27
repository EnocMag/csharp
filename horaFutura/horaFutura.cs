using System;

class horaFutura
{
    static void Main(string[] args)
    {
        Console.Write("Hora actual: ");
        string HoraActual = Console.ReadLine() ?? "Desconocido";
        Console.Write("Cantidad de horas: ");
        string CantidadHr = Console.ReadLine() ?? "Desconocido";

        int horaActual = 0;
        int cantidadHr = 0;

        if (int.TryParse(HoraActual, out horaActual) && int.TryParse(CantidadHr, out cantidadHr))   
        {   
            ProcesarNumero(horaActual, cantidadHr);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresa números enteros.");
        }
    }
    static void ProcesarNumero(int horaActual, int cantidadHr)
    {
        int horaFutura = (horaActual + cantidadHr) % 24;

        Console.WriteLine($"En {cantidadHr} horas, el reloj marcara las {horaFutura}");        
    }
}
        //crear un metodo que sea llamado si la condicion se cumple, si no se cumple probar si es por que el numero esta sobre el rango 
        //si esta sobre el reango sumarle 24 a lower y upper para tratar de nuevo llamando el metodo 
        //si esta debajo del rango (o dentro del rango) restar la cantidad de horas de lowerRange para obtener el resultado 
        //que hace el metodo? este restara a la suma de la horaActual y cantidadHr el lowerRange

        // if (res > 24 && res < 48)
        // {   
        //     res = res - 24;
        // }
        // if (res > 48 && res < 72)
        // {
        //     res = res - 48;
        // } ...

                // int lowerRange = 24;
        // int upperRange = 48;
        // int res = horaActual + cantidadHr;

        // dias(lowerRange, upperRange, res);
        
        // static int dias(int lowerRange, int upperRange, int res)
        // {
        //     if (res > lowerRange && res < upperRange)
        //     {
        //         res = res - lowerRange;
        //         return dias(lowerRange, upperRange, res);
        //     }
        //     else
        //     {
        //         lowerRange += 24;
        //         upperRange += 24;
        //         return dias(lowerRange, upperRange, res);
        //     }
        // }