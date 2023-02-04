// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите X1");
int X1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите Y1");
int Y1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите Z1");
int Z1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите X2");
int X2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите Y2");
int Y2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите Z2");
int Z2 = int.Parse(Console.ReadLine() ?? "0");
 
Console.WriteLine("Введите 1,если необходимо найти расстояние в 2D; Введите 2, если в 3D:");
int metod = int.Parse(Console.ReadLine() ?? "0");

if (metod == 1)
{
int c;
 c = ((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));
double C = Math.Sqrt(c);
Console.WriteLine(C);
}

else if (metod == 2)
{
int D;
 D = ((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
double d = Math.Sqrt(D);
Console.WriteLine(d);
}

else Console.WriteLine("Выберите 2D(1) или 3D(2)");