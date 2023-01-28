// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число N ");
int N = int.Parse(Console.ReadLine());

int i = (N % 100 - N % 10) / 10;
Console.WriteLine($"{i}");
