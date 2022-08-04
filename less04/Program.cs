// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, в степень которую возвести: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int GetDegree(int num_1, int num_2) {
    int res = num_1;
    for (int i = 1; i < num_2; i++)
    {
        res = num_1 * res;
    }
    return res;
}

Console.WriteLine($"Число {number_1} в степени {number_2} = {GetDegree(number_1, number_2)}");