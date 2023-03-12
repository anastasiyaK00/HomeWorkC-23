// Написать программу возведения числа А в целую стень B


//a^b=a*a*a...*b;


int Proizv(int A, int B)
{
   if (B == 1) return A;
   else return Proizv(A, B - 1) * A;


}


Console.WriteLine("a=: ");
int a = int.Parse(Console.ReadLine())!;
Console.WriteLine("b=: ");
int b = int.Parse(Console.ReadLine())!;


Console.WriteLine(Proizv(a, b));
