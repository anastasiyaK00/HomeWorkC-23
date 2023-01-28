// Найти максимальное из трех чисел

Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число C ");
int C = int.Parse(Console.ReadLine());

int max=A;

if (B > max)
     max = B;
if (C > max)
     max = C;

Console.WriteLine($"Максимальное число = {max}");