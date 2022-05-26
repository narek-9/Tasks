// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int a = 0;
int b = 1;
Console.WriteLine("Введите кол-во чисел Фибо։ ");
int n = int.Parse(Console.ReadLine());
Console.Write(a + " " + b + " ");
int sum = 0;
for (int i = 0; i < n+1; i++)
{
    sum = a + b;
    Console.Write(sum + " ");
    a = b;
    b = sum;
}