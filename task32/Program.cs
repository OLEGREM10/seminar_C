// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arr = FillArrayWithRandomNumbers(10, -10, 10); //Вызов метода
Console.WriteLine(string.Join(", ", arr)); // выводим исходный массив

SwapSignOfArrayElements(arr);  // вызов метода
Console.WriteLine(string.Join(", ", arr)); // выводим результирующий массив


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

void SwapSignOfArrayElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];  // меняем знаки с + на - и на оборот
        //array[i] = array[i] * -1; // здесь тоже самое меняем знаки
    }

}