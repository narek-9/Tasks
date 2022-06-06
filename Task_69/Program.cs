// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

MultiNumber(a, b, 0, 1);

void MultiNumber(int n, int m, int count, int multi)
{
    if(count == m)
    {
        Console.WriteLine($"{multi}");
        return;
    }
    multi *= n;
    count++;
    MultiNumber(n, m, count, multi);
}
