// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int sumWrite = WriteNaturalNum(m, n);

Console.Write($"M = {m}, N = {n} -> {sumWrite}");

if (n < m) Console.Write(" M > N!");

int WriteNaturalNum(int from, int to)
{
    if (from > to) return sum;
    sum += from;
    WriteNaturalNum(++from, to);
    return sum;
}