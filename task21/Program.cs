/* всевозможные проверки на корректность ввода не написаны (намеренно) */

Console.Write("Введите координаты первой точки (три числа через пробел): ");
var str = Console.ReadLine() ?? "";
string[] strArr = str.Split(' ');

int[] coord0 = new int[strArr.Length];
for (int i = 0; i < strArr.Length; i++)
    coord0[i] = int.Parse(strArr[i]);

Console.Write("Введите координаты второй точки (три числа через пробел): ");
str = Console.ReadLine() ?? "";
strArr = str.Split(' ');

int[] coord1 = new int[strArr.Length];
for (int i = 0; i < strArr.Length; i++)
    coord1[i] = int.Parse(strArr[i]);

Console.WriteLine(
    Math.Sqrt(Math.Pow((coord1[0] - coord0[0]), 2) + 
    Math.Pow((coord1[1] - coord0[1]), 2) + 
    Math.Pow((coord1[2] - coord0[2]), 2)).ToString());