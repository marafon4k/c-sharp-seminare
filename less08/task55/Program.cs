// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
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

int[,] matrixResoult = GetMatrix(3, 3);
PrintMatrix(matrixResoult);

int[,] ReplacingRowsColumns(int[,] matrixResoult)
{
    int[,] matrixNew = new int[matrixResoult.GetLength(0), matrixResoult.GetLength(1)];
    for (int i = 0; i < matrixResoult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResoult.GetLength(1); j++)
        {
            matrixNew[i, j] = matrixResoult[j, i];
        }
    }
    return matrixNew;
}

Console.WriteLine();

if (matrixResoult.GetLength(0) != matrixResoult.GetLength(1)) Console.WriteLine("Невозможно выполнить");
else
{
    int[,] newMatrix = ReplacingRowsColumns(matrixResoult);
    PrintMatrix(newMatrix);
}
