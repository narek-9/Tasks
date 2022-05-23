// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] num = new int [size];
int sumPos = 0; int sumNeg = 0;

var  newRnd = new Random();
for(int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(-100, 100);
    Console.Write(num[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine());

bool flag = false;

for (int i = 0; i < size; i++)
{
    if (num[i] == n) 
    {
        flag = true;
        break;
    }
}
Console.WriteLine(flag ?  "Да": "Нет");
