// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] matrixResoult = GetMatrix(3, 4);
PrintMatrix(matrixResoult);

double[] SumMatrix(int[,] matrix)
{
    int lineSum = matrix.GetLength(0); // 3
    int columnSum = matrix.GetLength(1); // 4

    double[] arr = new double[columnSum]; // 
    double numbers = columnSum; // 
    double sum = 0;

    for (int i = 0; i < columnSum; i++) // 
    {
        for (int j = 0; j < lineSum; j++) // 
        {
            sum += matrix[j, i];
        }
        sum /= columnSum;
        arr[i] = Math.Round(sum, 2);
    }
    return arr;
}

void PrintAverageArray(double[] array)
{
    Console.WriteLine($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]};  ");
    }
    Console.WriteLine();
}

double[] matrixSum = SumMatrix(matrixResoult);
PrintAverageArray(matrixSum);