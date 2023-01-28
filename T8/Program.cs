// Дано число из отрезка [10, 99]. 
//Показать наибольшую цифру числа

int A = new Random().Next(10,99);
Console.WriteLine($"Рандомное число - {A}");

int i = A%10;
int s = A/10;

if (i>s)
Console.WriteLine ($"{i} - большее число");
else 
Console.WriteLine ($"{s} - большее число");
