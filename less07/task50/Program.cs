// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

void FindMatrix(int[,] matrix)
{
    Console.WriteLine("Введите позиции элемента через пробел: ");
    string numbers = Console.ReadLine(); // Передаем значения с клавиатуры в строковую переменную
    int[] ints = numbers.Split(' ').Select(int.Parse).ToArray(); // создаем массив, конвертируем в него данные из строковой переменной в целочисленные
    int neededPos = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (ints[0] == i + 1 && ints[1] == j + 1)
            {
                neededPos = matrix[i, j];
                break;
            }
            else neededPos = -1;
        }
    }
    if (neededPos >= 0) Console.WriteLine($"На позиции строка {ints[0]}, столбец {ints[1]} число - {neededPos}]");
    else Console.WriteLine($"Строка {ints[0]}, столбец {ints[1]} - такого числа в массиве нет");
}

FindMatrix(matrixResoult);