 // Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число {number}");
int number1 = number % 10;
int number2 = number / 100;
//Console.WriteLine($"{number2}{number1}");
Console.WriteLine($"Результат выполнения равен{number2 * 10 + number1}");

