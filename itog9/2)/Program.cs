// Найти сумму элементов от M до N, N и M заданы


int Sum(int M, int N)
{
   if (M > N) return 0;
   else return M + Sum(M + 1, N);
}
//int m = int.Parse(Console.ReadLine());
//int n = int.Parse(Console.ReadLine());


System.Console.WriteLine(Sum(6, 7));
