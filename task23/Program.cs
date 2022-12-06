Console.Write("Введите число кубов: ");
var str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out int num))
{
    Console.WriteLine($"{str} не является числом");
    return;
}

Console.Write($"Таблица кубов чисел от 1 до {str}: ");
for (int i = 1; i <= num; i++)
    Console.Write(Math.Pow(i, 3).ToString() + " ");
