// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int N = int.Parse (Console.ReadLine());

int a = (N / 10) % 10;

Console.WriteLine($"Второе число введенного трехзначного числа - {a}");