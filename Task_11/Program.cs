int number = new Random().Next(100, 1000);
int last = number % 10;
int first = number / 10;
int res = first * 10 + last;
Console.WriteLine($"Случайное число = {number}");
Console.WriteLine($"Результат = {res}");
