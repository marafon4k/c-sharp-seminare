// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количетсво элеметов в массив: ");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nСумма элементов на нечетных позициях: {CheckEvenPositionArr(SetRndInt(amount))}");

int[] SetRndInt(int size) // Задаем массив с рандомными значениями от -99 до 99
{
    int[] arr = new int[size];
    Random rnd = new Random();
    Console.Write("Массив создан: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-99, 100);
        Console.Write($"{arr[i]} "); // Выводил для теста цифр
    }
    return arr;
}

int CheckEvenPositionArr(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0 || i == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}