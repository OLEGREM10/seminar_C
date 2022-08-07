     //Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("Введите число");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Введите второе число");
int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

   if(num == num1 * num1 || num1 == num * num){
     Console.WriteLine("Да");
   }
   else{
    Console.WriteLine("Нет");   
   }
 
