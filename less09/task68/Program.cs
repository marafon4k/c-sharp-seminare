// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Задайте число M: ");
int mInt = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int nInt = Convert.ToInt32(Console.ReadLine());


int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    else
        return n + 1;
}

int sumAckerman = Ackerman(mInt, nInt);
Console.WriteLine($"m = {mInt}, n = {nInt} -> A(m,n) = {sumAckerman}");