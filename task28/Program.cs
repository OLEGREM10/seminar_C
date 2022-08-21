//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
int factor = 1;
while(i <= num)
{
    factor =i * factor;
    i++;
}
Console.WriteLine(factor);