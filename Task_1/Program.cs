Console.Write("Введите число 1 -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 -> ");
int num2 = int.Parse(Console.ReadLine());
bool result = num2 * num2 == num1;
Console.WriteLine(result ? "Да" : "Нет");

