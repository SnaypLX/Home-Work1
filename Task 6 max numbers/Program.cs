// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


Random rnd = new Random();

int N = rnd.Next(10, 99);

int a = (N / 10) % 10;
int b = N  % 10;

if (a > b)
{
Console.WriteLine($"Максимальная цифра числа {N} - {a}");
}

else
{
Console.WriteLine($"Максимальная цифра числа {N} - {b}");
}