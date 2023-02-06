// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");


int i = 1;
int pr = 1;
while (i < n + 1)
{
    pr = pr*i;
    Console.WriteLine($"Произведение чисел от 1 до {i} = {pr}");
    i++;
}
Console.WriteLine($"Ответ: {pr}");