// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
using System;
namespace vtornik
{
    class Program
    {
         static void Main(string[] args)
        {
            string Queue( int i, int N)
            {
                
                if (i > N) return " ";
                else return $"{i}, " + Queue(i + 1, N);
            }
            Console.WriteLine(Queue(1, 10));

        }
        
}
}

