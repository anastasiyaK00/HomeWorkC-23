// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите 1-ое число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Dедите 2-ое число B: ");
int b = int.Parse(Console.ReadLine());

// я тут проверяю каждое число, усложнила ахах
if (a * a == b)
{
    Console.WriteLine($"{b} является квадратом числа {a}");
}
else if (b * b == a)
{
    Console.WriteLine($"{a} является квадратом числа {b}");
}
else
{
   Console.WriteLine("Не является");
}

/* РЕШЕНИЕ ПРЯМО ПО УСЛОВИЯМ
if (a * a == b)
{
    Console.WriteLine($"{b} является квадратом числа {a}");
}
else
{
   Console.WriteLine("Не является");
}
*/