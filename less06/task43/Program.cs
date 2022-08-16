// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;

double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
double x = y1 + y2;

Console.WriteLine(x, y1, y2);