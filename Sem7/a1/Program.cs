// // Дан целочисленный массив.
// Найти среднее арифметическое каждого из столбцов.


int[,] matrix = new int[2, 3];


void PrintArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int k = 0; k < matrix.GetLength(1); k++)
       {
           System.Console.Write($"{matrix[i, k]}");
       }
       System.Console.WriteLine();
   }
}
void FillArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int k = 0; k < matrix.GetLength(1); k++)
       {
           matrix[i, k] = new Random().Next(1, 10);
       }
       System.Console.WriteLine();
   }
}


FillArray(matrix);
PrintArray(matrix);


void SrAr(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       double sum = 0;
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           sum = matrix[i, j] + sum;
       }
       double srarif = sum / matrix.GetLength(1);
       Console.WriteLine(srarif);
   }
}
SrAr(matrix);

