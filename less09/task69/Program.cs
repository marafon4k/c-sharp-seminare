// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.Write("Задайте число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int QuaterAB(int a, int b)
{
    if (b == 0) return 1;
    return QuaterAB(a, b - 1) * a;
}
int sumNumber = QuaterAB(a, b);
Console.WriteLine($"A = {a}; B = {b} -> {sumNumber}");