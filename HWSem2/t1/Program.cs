//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
/*
int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5; */
int Saturday = 6;
int Sunday = 7;

Console.WriteLine("Введите номер дня недели ");
int A = int.Parse(Console.ReadLine());
 
 if (A == Saturday || A == Sunday)
Console.WriteLine("Да, заданное вами число является выходным днем");
else 
Console.WriteLine("Нет, заданное число обозначает будний день");
