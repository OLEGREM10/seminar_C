//Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

      
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num % 7;
int temp1 = num % 23;

   if(temp == 0 & temp == 0)
   {
     Console.WriteLine($"{num} кратно 7 и 23");
   }
   else
   {
     Console.WriteLine($"{num} не кратно 7 и 23");
   }
