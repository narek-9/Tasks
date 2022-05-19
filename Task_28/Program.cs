// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Ведите число");
int number = int.Parse(Console.ReadLine());
int summ = 0;

int SummNumber (int number)
{
    int summ = 1;
    for (int i = 1; i <= number; i++)
    {
        summ = summ * i;

    }
    return summ;
}
int result = SummNumber (number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");