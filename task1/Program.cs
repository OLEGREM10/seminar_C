//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число "); // Просим пользователя ввести первое число
int number = Convert.ToInt32(Console.ReadLine()); // Конвертируем строковый тип в целочисленый
Console.WriteLine("Введите второе число ");
int number_1 = Convert.ToInt32(Console.ReadLine());
    if(number == number_1 * number_1){ // Сравниваем первое число со вторым ^2
        Console.WriteLine("Да является");
}   else{
        Console.WriteLine("Не является");
}