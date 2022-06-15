// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26
// bool run = true;
// while (run)
// {

    Console.Clear();
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Задайте число N: ");
    int n = int.Parse(Console.ReadLine());

    void GetProgSum(int num1, int num2, int count)
    {
        int sum = 0;
        if (count == 2) return;

        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.Write($"{sum} ");
        GetProgSum(num1, num2, count - 1);
    }
    Console.Write($"{a} {b} ");
    GetProgSum(a, b, n);
    // Console.WriteLine("Ещё раз? y/n");
    // run = Console.ReadKey() == ConsoleKey.Y;


