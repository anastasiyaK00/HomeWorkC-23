// Удалить вторую цифру трёхзначного числа

int A = new Random().Next(100,999);
Console.WriteLine($"Рандомное число - {A}");

int i = A/100;
int b = A%10;
int c = i*10+b;

Console.WriteLine ($"{c}");
