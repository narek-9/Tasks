// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

NaturalNumber(m, n);
Console.ReadKey();

void NaturalNumber(int m, int n)
{
    if (m > n)
    {
        Console.Write(m + " ");
        if (m == n) return;
        NaturalNumber(m - 1, n);
    }

    if (m <= n)
    {
        Console.Write(m + " ");
        if (m == n) return;
        NaturalNumber(m + 1, n);
    }
}