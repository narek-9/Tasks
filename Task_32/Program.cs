﻿// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int len = 4;
int[] array = new int[len];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-20, 21);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
}