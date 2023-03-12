// Найти сумму цифр числа


int Sum (int n)
{
   if (n<1) return 0;
   return Sum(n/10)+ n%10;
}
System.Console.WriteLine("Add N: ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Sum (N));
