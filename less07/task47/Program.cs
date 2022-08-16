// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// [0,5; 7; -2; -0,2]
// [1; -3,3; 8; -9,9]
// [8; 7,8; -7,1; 9]


double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * 2 - 1) * 10, 1);
            // matrix[i, j] = rnd.NextDouble(-99, 100);
            // Math.Round(rnd.NextDouble() * 100, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}; ");
            else Console.Write($"{array[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

double[,] matrixResoult = GetMatrix(3, 4);
PrintMatrix(matrixResoult);