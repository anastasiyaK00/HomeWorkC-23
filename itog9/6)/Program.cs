//Написать программу показывающие первые N чисел,
//для которых каждое следующее равно сумме двух предыдущих.
//Первые два элемента последовательности задаются пользователем


int Fib(int n)
{
   if(n == 1 || n == 2) return 1;
   else return Fib(n-1) + Fib(n-2);
}
for (int i = 1; i < 10; i++)
{
   Console.WriteLine(Fib(i));
}


Console.WriteLine("add a: ");
int a = int.Parse(Console.ReadLine())!;
Console.WriteLine("add b: ");
int b = int.Parse(Console.ReadLine())!;

