// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число");
int a = int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse (Console.ReadLine());

if ( a % b == 0)
{
    Console.WriteLine($"Число {a} кратно {b}");
}

else
{
    int c = a % b;

    Console.WriteLine($"Остаток при делении числа {a} на {b} равен {c}");
}