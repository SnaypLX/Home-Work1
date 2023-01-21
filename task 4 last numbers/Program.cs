// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число ");
int N = int.Parse (Console.ReadLine());

int a = N  % 10;

Console.WriteLine($"Третье число введенного трехзначного числа - {a}");