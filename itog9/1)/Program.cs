// Показать натуральные числа от M до N, N и M заданы


string Numbers(int M, int N)
{
   if (M <= N) return $"{M}" + Numbers(M+1,N);
   else return String.Empty;
}


System.Console.WriteLine(Numbers(1, 8));
