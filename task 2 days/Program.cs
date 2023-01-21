// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели(1 - понедельник.... 7 - воскресенье)");

int a = int.Parse(Console.ReadLine());



if (a == 1)

{
    Console.WriteLine("День недели - понедельник");
}

else if (a == 2)

{
    Console.WriteLine("День недели - вторник");
}

else if (a == 3)

{
    Console.WriteLine("День недели - среда");
}

else if (a == 4)

{
    Console.WriteLine("День недели - четверг");
}

else if (a == 5)

{
    Console.WriteLine("День недели - пятница");
}

else if (a == 6)

{
    Console.WriteLine("День недели - суббота, выходной!");
}

else if (a == 7)

{
    Console.WriteLine("День недели - воскресенье, выходной!");
}

