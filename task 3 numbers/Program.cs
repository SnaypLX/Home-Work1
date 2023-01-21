// Показать четные числа от 1 до N

Console.WriteLine("Введите число для отображение четных чисел");

int N = int.Parse(Console.ReadLine());

if (N < 2) 
{
    Console.Write("Четных чисел нет");
}

else

{
    for (int a = 2; a <= N; a = a + 2)
{
    Console.WriteLine(a);
}

}