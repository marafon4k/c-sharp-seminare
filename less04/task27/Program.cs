// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum(int x) {
    int sum = 0;

    for (int i = x; i > 10; i--)
    {
        sum += x % 10;
        x -= x % 10;
        x /= 10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр числа - {GetSum(number)}");