// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] array(int[,] array)
{
    int[] arrayNew = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayNew[array[i, j]]++;
        }
    }
    return arrayNew;
}

int[] ConversionArray(int[,] matrix)
{
    int[] arrayNew = new int[matrix.Length];
    int z = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrayNew[z] = matrix[i, j];
            z++;
        }
    }
    Array.Sort(arrayNew);
    return arrayNew;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]};  ");
    }
    Console.WriteLine();
}

void WriteDigitCountToConsole(int[] arrayNew)
{
    int number = arrayNew[0];
    int count = 0;
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (arrayNew[i] == number) count++;
        else
        {
            Console.WriteLine($"Число {number} встречается -> {count} раз");
            number = arrayNew[i];
            count = 1;
        }
        if(i == arrayNew.Length - 1) Console.WriteLine($"Число {number} встречается -> {count} раз");
    }
}

int[,] matrixResoult = GetMatrix(3, 3);
PrintMatrix(matrixResoult);

int[] arrayNew = ConversionArray(matrixResoult);
WriteDigitCountToConsole(arrayNew);
