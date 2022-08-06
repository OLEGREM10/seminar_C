

Console.Write("Введите число "); // 1. предлогаем пользователю ввести число
//int number = Convert.ToInt32(Console.ReadLine()); // 2.  Считывание строковых данных и преоброзование в тип int
string? str = Console.ReadLine(); // 2.1 Считываем данные введеные пользователем с консоли
int number = Convert.ToInt32(str); // 2.2 конвертируем из строкового типа в целочисленый тип
Console.Write(number * number); // 3.Вывод на экран квадрат числа,number ^ 2



