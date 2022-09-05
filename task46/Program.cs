
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19 
// 5 -2 33 -2 
// 77 3 8 1
// 
// 


Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); //количество строк
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
int[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrintMatrix(ourMatrix);
SqrEvenIndexes(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SqrEvenIndexes(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i=i+2)
    {
        for (int j = 0; j < matrix.GetLength(1); j=j+2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return;
}    




// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine()); //количество строк
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine()); //количество столбцов
// int[,] ourMatrix = GetMatrix(m, n, -10, 10);
// PrintMatrix(ourMatrix);
// int summ = GetSumMainDiagonal(ourMatrix);
// Console.WriteLine(summ);



// int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
// {
//     int[,] matrix = new int[rowsCount, columnsCount];

//     Random rand = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(leftRange, rightRange);
//         }
//     }

//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int GetSumMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     int min;
//     if (matrix.GetLength(0) > matrix.GetLength(1))
//     {
//         min = matrix.GetLength(1);
//     }
//     else
//     {
//         min = matrix.GetLength(0);
//     }

//     for (int i = 0; i < min; i++)
//     {
//         sum = sum + matrix[i,i];
//     }
//     return sum;
// }