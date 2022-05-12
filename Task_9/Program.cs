
int number = new Random().Next(10, 100);
Console.WriteLine($"Number = {number}");
int maxNum = FindMaxNumber (number);
Console.WriteLine($"Max = {maxNum}");

int FindMaxNumber (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}