﻿//Задача 22: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1;i <= num; i++) //  в цикле for объявляем переменную i со значением 1.Делаем условие
                              //до тех пор пока i меньше или равно num ,мы делаем то что у нас 
                              
{
    Console.Write(i * i + " ");// в теле цикла i*i, а затем к i плюсуем 1
}
