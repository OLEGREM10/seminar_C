//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
//for(int i = 0; num > 0; i++)
while(num  > 0 )
{
     num = num / 10;
    i += 1;


}
Console.WriteLine(i);