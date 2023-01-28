// Выяснить, кратно ли число заданному, 
//если нет, вывести остаток.

Console.WriteLine("Введите число  ");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число  ");
double B = double.Parse(Console.ReadLine());
double c;

if (A % B == 0)
{
    c = A / B;
    Console.WriteLine($"Кратное, ответ {c} ");
}

else
{
    c = A % B;
    Console.WriteLine($"НЕКратное, остаток от деления {c} ");
}