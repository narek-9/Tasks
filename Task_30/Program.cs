Console.Clear();
int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] col)
{
    int size = col.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{col[1]},");
    }
}

FillArray(array);
PrintArray(array);