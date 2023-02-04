// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число:____");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число:____");
int B = int.Parse(Console.ReadLine() ?? "0");

if (A / B == B)
    Console.WriteLine($"A = {A} - квадрат числа B = {B}");
else if (B / A == A)
    Console.WriteLine($"B = {B} - квадрат числа A = {A}");
else
    System.Console.WriteLine("Ни A ни B не являются квадратами");