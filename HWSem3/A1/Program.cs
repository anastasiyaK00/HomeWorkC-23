// Найти кубы чисел от 1 до N
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int i = 1;
int k = 1;
while (i < N + 1)
{
    k = i * i * i;
    Console.WriteLine($"{i} в кубе = {k}");
    i++;
}