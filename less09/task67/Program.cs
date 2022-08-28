// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int Sum(int num)
{
    if (num == 0) return sum;
    sum += num % 10;
    Sum(num/10);
    return sum;
}
int sumNumber = Sum(number);
Console.WriteLine(sumNumber);