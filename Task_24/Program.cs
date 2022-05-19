Console.Write("Введите натуральное число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum; 

}

int sumResult = GetSumNumbers(num);

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumResult}");
