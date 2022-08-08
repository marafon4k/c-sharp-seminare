// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// 1. Создать массив N-элементов
// 2. Заполнить массив случайными 3х значными числами
// 3. Проверить каждый элемент массива на четность
// 4. Если число четное, то прибавить к сумме 1.
// 5. Вывести результат


int[] SetRndPosInt (int size) {
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        // Console.WriteLine(arr[i]); // Выводил для теста цифр
    }
    return arr;
}

int GetEvenInt (int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine("Введите количетсво элеметов в массив: ");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetEvenInt(SetRndPosInt(amount)));