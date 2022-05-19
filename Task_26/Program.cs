Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number < 0) number = number * -1;

int FindNumV(int num)
{
    int div = 1;
    int count = 0;
    int num2 = 0;
    while (num > div)
    {
        num2 = num / div;
        div = div * 10;
        count++;
    }
    return count;
}

Console.WriteLine($"Количество цифр в числе = {FindNumV(number)}");