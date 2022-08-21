// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[12];

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);

    if (array[i] > 0) //Если наш элемент положительный
    {
        sumPositive = sumPositive + array[i]; //накапливаем положительную сумму
        //sumPositive += array[i];
    }
    else // если элементы с отрицательным значением
    {
        sumNegative += array[i]; // накапливаем отрицательную сумму
        //sumNegative = sumNegative + array[i];
    }


}

Console.WriteLine(string.Join(", ", array));  // Выводим исходный массив
Console.WriteLine($"Сумма положительных элементов массива = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumNegative}");
