// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
//  int num1 = 0;
//  string num2;
// while (num > 0 );
// {
//     num1 = num % 2;
//     num = num / 2;
    
    
// }
// Console.WriteLine(num1);



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number)  // Метод Рекурсии
{
    if (number <= 0) return;
    GetBinaryView(number / 2);  //вызов метода внутри метода называется рекурсия
    Console.Write(number % 2);
}