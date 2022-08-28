// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int num)
// {
//     if (num == number2-1) return;
//     NaturalNumber(num - 1);
//     Console.Write($"{num} ");
// }

// NaturalNumber(number1);


Console.Write($"M = {m}, N = {n} -> ");
WriteNaturalNum(m, n);
if (n < m) Console.Write(" M > N!");

void WriteNaturalNum(int from, int to)
{
    if (from > to) return;
    System.Console.Write($"{from} ");
    WriteNaturalNum(++from, to);
}