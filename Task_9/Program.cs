
int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine($"Number 1 {firstDigit}");
Console.WriteLine($"Number 2 {secondDigit}");
Console.WriteLine(firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");