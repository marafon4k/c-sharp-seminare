// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите количетсво элеметов в массив: ");
int amount = Convert.ToInt32(Console.ReadLine());
var arr = SetRandomDouble(amount);
var diff = GetDiff(arr);
Console.WriteLine($"Разница мин. и макс. числом массива - {diff.ToString("F2")}");

double[] SetRandomDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    Console.Write("Массив создан: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

double GetDiff(double[] arr)
{
    double min = 100;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    double sum = max - min;
    return sum;
}