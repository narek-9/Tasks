Console.Write("Задайте размер масиива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите элементы масиива через пробел: ");


int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(string.Join(' ', numsArr));

// int[] nums = new int[size];
int positive = 0;
int negative = 0;

// var newRnd = new Random(); 
// for (int i = 0; i < size; i++)
// {
//     nums[i] = newRnd.Next(-9, 10);
//     Console.Write(nums[i] + " ");
// }

for (int i = 0; i < numsArr.Length; i++)
{
    if(numsArr[i] > 0) positive += numsArr[i];
    else negative += numsArr[i];

}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов масиива = {positive}");
Console.WriteLine($"Сумма отрицательных элементов масиива = {negative}");