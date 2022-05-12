Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
bool res = a % 7 == 0 && a % 23 == 0;
Console.WriteLine(res ? "Yes" : "No");