// Выяснить является ли число чётным

Console.WriteLine("Введите число  ");
int A = int.Parse(Console.ReadLine());

if (A % 2 == 0)
{
    Console.WriteLine($"{A}-число четное");
}
else
{
    Console.WriteLine($"{A}-число Нечетное");
}
