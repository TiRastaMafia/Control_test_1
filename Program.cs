
// Объявление массива с сепарацией через пробел
string[] Masive;
Console.WriteLine("Введите слова через пробел"); string? stroka = Console.ReadLine();
Masive = stroka.Split(' ');

Console.WriteLine("Введите меньше какой длинны символов будут слова"); int n = Convert.ToUInt16(Console.ReadLine());

var result = new string[Masive.Length];
var realSize = 0;
// проверка каждого значения на <= 3 и запись в новый массив
foreach (var value in Masive)
{
    if (value.Length <= n)
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.Write($"новый массив равен -> {(string.Join(" ", result, 0, realSize))}");
Console.ReadKey(true);