// По заданному номеру дня недели вывести его название

int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;

Console.WriteLine("Введите номер дня недели ");
int A = int.Parse(Console.ReadLine());
 
 if (A == Monday)
Console.WriteLine("Monday");
 if (A == Tuesday)
Console.WriteLine("Tuesday");
 if (A == Wednesday)
Console.WriteLine("Wednesday");
 if (A == Thursday)
Console.WriteLine("Thursday");
 if (A == Friday)
Console.WriteLine("Friday");
 if (A == Saturday)
Console.WriteLine("Saturday");
 if (A == Sunday)
Console.WriteLine("Sunday");
