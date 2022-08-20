// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int[,] matrixResoult = GetMatrix(4, 3);
PrintMatrix(matrixResoult);

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                int max = matrix[i, k]; // максимальный эл-т - текущий
                if (matrix[i, k] < matrix[i, k + 1]) // если текущий элемент меньше следующего
                {
                    int tmp = matrix[i, k + 1]; // записываем во временную пер-ю значение след. эл-та
                    matrix [i, k + 1] = matrix[i, k]; // в следующий элемент вставляем текущий
                    matrix[i, k] = tmp; // в текущий вставляем из врем-й пер-ой темпа
                    max = matrix[i, k]; // максимальный элемент становится текущий
                }
            }
        }
    }
    return matrix;
}

Console.WriteLine();

int[,] test = SortMatrix(matrixResoult);
PrintMatrix(test);