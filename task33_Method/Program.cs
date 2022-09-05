// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)  // метод возвращает массив на size элементов
{
    int[] array = new int[size];  //задаем массив на size элементов

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange +1);

    }

    return array;

}

int[] arr = FillArrayWithRandomNumbers(10, -10, 10); //Вызов метода
Console.WriteLine(string.Join(", ", arr)); // выводим исходный массив

Console.WriteLine("Какое число вы хотите найти в массиве? ");
int number = Convert.ToInt32(Console.ReadLine());  //введеное число которое хочет найти пользователь
bool result = IsNumberInArray(arr, number);
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
bool IsNumberInArray(int[] array, int findNumber)
{
    bool flag = false;  // если элемента в массиве нет, то false, иначе - true

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == findNumber)
        {
            flag = true; // искомый элемент найден
            break;
        }
    }
    return flag;
}

