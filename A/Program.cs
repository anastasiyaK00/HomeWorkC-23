﻿// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int S = int.Parse(Console.ReadLine() ?? "0");
//int k = S;
int sum = 0;
int i = 0;
while (S > 0)
{
    sum = sum + S % 10;
    i++;
}
S = S / 10;

Console.WriteLine(sum);