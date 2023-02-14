// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, 
//y = k2 * x + b2,
// b1 k1 и b2 и k2 заданы

System.Console.WriteLine("Введите к1:");
double k1 = double.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите b1:");
double b1 = double.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите к2:");
double k2 = double.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите b2:");
double b2 = double.Parse(Console.ReadLine() ?? "0");

//double y1 = k1 * x + b1;
//double y2 = k2 * x + b2;
//k1x+b1=k2x+b2;
//k1x-k2x=b2-b1;
// сокращая уравнение получаем следующую формулу:
double x = (b2 - b1) / (k1 - k2);
double y = ((k1 * (b2 - b1)) / (k1 - k2)) + b1;

Console.WriteLine($"{x},{y}");
