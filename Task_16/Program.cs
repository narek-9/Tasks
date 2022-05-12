Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B :");
int b = int.Parse(Console.ReadLine());
bool res = b == a * a || a == b * b;
Console.WriteLine(res ? "Да" : "Нет");
