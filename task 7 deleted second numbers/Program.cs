// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int N = int.Parse (Console.ReadLine());

int a = (N / 100) % 10;
int b = (N / 10) % 10;
int c = N  % 10;

Console.WriteLine($"Второе число введенного трехзначного числа - {b}");

int d = a*10 + c;

Console.WriteLine($"Число {N} без второго числа - {d}");