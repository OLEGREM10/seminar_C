// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int [] array =FillArrayWithRandomNumbers(ARRAY_SIZE, LEFT_RANGE,RIGHT_RANGE );
Console.WriteLine($"Исходный массив: {string.Join(",", array)}");
ReversArray(array);
Console.WriteLine($"Перевернутый массив: {string.Join(",", array)}");

// метод возвращает массив на size элементов
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)  
{
    int[] array = new int[size];  //задаем массив на size элементов

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange +1);

    }

    return array;

}

void ReversArray(int[] array)   // Метод для разворота массива
{
    for (int i = 0; i < array.Length / 2;i++)
    {
        int temp = array[i];
        array[i] = array [array.Length -1 -i];
        array [array.Length -1 -i] = temp;
    }
}