//Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите число, чтобы узнать какой день недели соответствует ему");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 & number >= 1){ // Должно совпасть два условия не больше 7,и не меньше 1
    if(number == 1){ // Далее сравниваем введеное число с установленым для дня недели
       Console.WriteLine("Понедельник"); // далее ввыводим день недели соответствующий введеному числу
}   if(number == 2){
       Console.WriteLine("Вторник");
}    if(number == 3){
       Console.WriteLine("Среда");
}   if(number == 4){
       Console.WriteLine("Четверг");
}   if(number == 5){
       Console.WriteLine("Пятница");
}   if(number == 6){
       Console.WriteLine("Суббота");
}   if(number == 7){
       Console.WriteLine("Воскресенье");
} 
} 
else {
       Console.WriteLine("Такого дня недели не существует"); // выводим пользователю сообщение если он ввел число не соответствующее нашему условию
}

        
