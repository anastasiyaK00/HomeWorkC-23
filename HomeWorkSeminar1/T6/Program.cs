// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число N ");
int N = int.Parse(Console.ReadLine());

int i = N%10;
 Console.WriteLine($"{i}");