﻿// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    
    int[] num = new int [size];
    int sumPos = 0; int sumNeg = 0;

    var newRnd = new Random();
    for (int i = 0; i < size; i++)
    {
        num[i] = newRnd.Next(-10, 10);
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();

    int[] res = new int[num.Length/2];

    for (int i = 0; i < res.Length; i++)
    {
        res[i] = num[i] * num[num.Length-1-i];
        Console.Write(res[i] + " ");
    }


    Console.WriteLine("Попробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
}
