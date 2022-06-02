﻿// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите колличесвто строк: ");
int userRow = int.Parse(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов: ");
int userColumn = int.Parse(Console.ReadLine());

int [,] array = GetArray(userRow, userColumn);
PrintArray(array);

int [,] ChangeArrayString (int [,] array)
{
    int [,] flipArray = new int[userRow,userColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            flipArray[i, j] = array [j , i];
        }
    }
    return flipArray;
}

int [,] flipArray = ChangeArrayString(array);
Console.WriteLine();
PrintArray(flipArray);
