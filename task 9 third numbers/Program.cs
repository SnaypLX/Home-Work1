// Найти третью цифру числа или сообщить, что её нет


Console.WriteLine("Введите число");
int N = int.Parse (Console.ReadLine());

if (N < 100)
{
    Console.WriteLine($"Третьей цифры в числе {N} нет");
}

else
{
    while (N> 1000)
    N = (N / 10);
 int c = (N % 10);

    Console.WriteLine($"Третья цифра числа - {c}");
  
}