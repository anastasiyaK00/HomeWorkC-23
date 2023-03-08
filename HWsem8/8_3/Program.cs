﻿//Сформировать трехмерный массив не повторяющимися двузначными числами
//показать его построчно
//на экран выводя индексы соответствующего элемента


Console.WriteLine($"Введите размер массива X x Y x Z:");
int x = numbers ("Введите X: ");
int y = numbers ("Введите Y: ");
int z = numbers ("Введите Z: ");

int[,,] array3 = new int[x, y, z];
CreateArray(array3);
WriteArray(array3);


int numbers (string input)
{
 Console.Write(input);
 int output = Convert.ToInt32(Console.ReadLine());
 return output;
}
void WriteArray (int[,,] array3)
{
 for (int i = 0; i < array3.GetLength(0); i++)
 {
   for (int j = 0; j < array3.GetLength(1); j++)
   {
     Console.Write($"X({i}) Y({j}) ");
     for (int k = 0; k < array3.GetLength(2); k++)
     {
       Console.Write( $"Z({k})={array3[i,j,k]}; ");
     }
     Console.WriteLine();
   }
   Console.WriteLine();
 }
}
void CreateArray(int[,,] array3)
{
 int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
 int  number;
 for (int i = 0; i < temp.GetLength(0); i++)
 {
   temp[i] = new Random().Next(10, 100);
   number = temp[i];
   if (i >= 1)
   {
     for (int j = 0; j < i; j++)
     {
       while (temp[i] == temp[j])
       {
         temp[i] = new Random().Next(10, 100);
         j = 0;
         number = temp[i];
       }
         number = temp[i];
     }
   }
 }
 int count = 0;
 for (int x = 0; x < array3.GetLength(0); x++)
 {
   for (int y = 0; y < array3.GetLength(1); y++)
   {
     for (int z = 0; z < array3.GetLength(2); z++)
     {
       array3[x, y, z] = temp[count];
       count++;
     }
   }
 }
}
