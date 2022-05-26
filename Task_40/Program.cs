// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());

if(num1 + num2 < num3 || num1 + num3 < num2 || num2 + num3 < num1)
{
    Console.WriteLine($"Треугольник со сторонами {num1},{num2},{num3} не существует.");
}

else
{
    Console.WriteLine($"Трегольник со сторонами {num1},{num2},{num3} существует.");
}