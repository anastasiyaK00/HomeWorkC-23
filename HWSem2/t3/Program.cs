﻿//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти:");
int A = int.Parse(Console.ReadLine() ?? "0");

if (A == 1)
{
    Console.WriteLine("Плоскость, где x=(0;+x), y=(0;+y) - значения x и y будут положительными");
}
else if (A == 2)
{
    Console.WriteLine("Плоскость,где x=(0;-x), y=(0;+y) - значение y будет положительными, а x отрицательным");
}
else if (A == 3)
{
    Console.WriteLine("Плоскость, где x=(0;-x), y=(0;-y) - обе координаты x и y будут иметь отрицательные значения");
}
else if (A == 4)
{
    Console.WriteLine("Плоскость, где x=(0;+x), y=(0;-y) - значение x будет положительным, а y отрицательным");
}
