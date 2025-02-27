using System;
class NumbersOneEight
{
    static void Main(string[] args)
    {

        for (int i = 1; i <= 8; i++)
        {
            for (int a = i - 1; a > 0; a--)
            {
                Console.Write($" ");
            }

            for (int j = i; j <= 8; j++)
            {
                Console.Write($"{j}");
            }
            Console.Write($"\n");
        }

        for (int i = 8; i >= 1; i--)
        {
            for (int a = i - 1; a > 0; a--)
            {
                Console.Write($" ");
            }
            
            for (int j = i; j <= 8; j++)
            {
                Console.Write($"{j}");
            }
            Console.Write($"\n");
        }

        // int x = 8;
        // do 
        // {
        //     Console.Write($"{x}");
        //     x--;
        // } 
        // while(x >= 1);

    }
}