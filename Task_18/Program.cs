Console.WriteLine("Введите номер четверти");
var number = Console.ReadLine();

if (number == "1")
{
    Console.WriteLine("x > 0 и y > 0");
}
else if (number == "2")
{
    Console.WriteLine("x < 0 и y > 0");
}
else if (number == "3")
{
    Console.WriteLine("x < 0 и y < 0");
}
else if (number == "4")
{
    Console.WriteLine("x > 0 и y < 0");
}
else Console.WriteLine("Вы ввели некорректные значения");
