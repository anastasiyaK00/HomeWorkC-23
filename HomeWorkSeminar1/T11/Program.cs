// Найти третью цифру числа или сообщить, что её нет


Console.WriteLine("Введите число  ");
int A = int.Parse(Console.ReadLine());
int c = 0;

if (A < 100)
{
    Console.WriteLine("число не имеет третью цифру");
}
else
{
    if (A < 1000)
    {
        A = A % 10;
    }
    else
        while (A > 999)
        {
            A = A / 10;
            c++;
        }
        A = A % 10;
    Console.WriteLine($" A={A} третья цифра заданного числа");
}