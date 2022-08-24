// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] GetMatrix(int m, int n, int k)
{
    int[,,] matrix = new int[m, n, k];
    int number = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                number += 3;
                matrix[i, j, z] = number;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] array)
{
    int[] numberIndex = { 0, 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if (z == 0) Console.Write("[");
                if (z < array.GetLength(1) - 1)
                {
                    Console.Write($"{array[i, j, z],3} ");
                    Console.Write($"({numberIndex[0]},{numberIndex[1]},{numberIndex[2]})");
                    numberIndex[1] = 1;
                }
                else
                {
                    Console.Write($"{array[i, j, z],3}");
                    Console.Write($"({numberIndex[0]},{numberIndex[1]},{numberIndex[2]}) ]");
                }
            }
            numberIndex[1] = 0;
            numberIndex[0] = 1;
            Console.WriteLine();
        }
        numberIndex[0] = 0;
        numberIndex[1] = 0;
        numberIndex[2] = 1;
        Console.Write("");
    }
}

int[,,] matrixResoult = GetMatrix(2, 2, 2);
PrintMatrix(matrixResoult);