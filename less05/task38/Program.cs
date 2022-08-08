// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите количетсво элеметов в массив: ");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetDiff(SetRndFlt(amount)));

double[] SetRndFlt(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
        Console.WriteLine(arr[i]); // Выводил для теста цифр
    }
    return arr;
}

double GetDiff(double[] arr)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    double sum = max - min;
    return sum;
}