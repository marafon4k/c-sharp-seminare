// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
int arrL = array.Length;

for (int i = 0; i < arrL; i++)
{
    array[i] = new Random().Next(1, 50);
}

Console.Write("[");
for (int i = 0; i < arrL; i++)
{
    Console.Write($"{array[i]}");
    if (i != arrL-1) Console.Write(", ");
}
Console.Write("]");