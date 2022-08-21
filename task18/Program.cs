//Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("введите номер четверти");
int guarter = Convert.ToInt32(Console.ReadLine());
 

//if(guarter < 1 & guarter > 4)
//{
//    Console.WriteLine("Введите одну из четвертей");
//}
if(guarter == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if(guarter == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if(guarter == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if(guarter == 4)
{
    Console.WriteLine("x >  0 && y < 0");
}
else
{
    Console.WriteLine("Такой четверти нет");
}