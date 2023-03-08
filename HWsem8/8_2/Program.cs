// В двумерном массиве целых чисел. Удалить строку и столбец,
//на пересечении которых расположен наименьший элемент.


void FillArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int k = 0; k < matrix.GetLength(1); k++)
       {
           matrix[i, k] = new Random().Next(1, 10);
       }
   }
}
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
int SearchMin(int[,] matrix)
{
   int min = matrix[0, 0];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int k = 0; k < matrix.GetLength(1); k++)
       {
           if (min > matrix[i, k])
           {
               min = matrix[i, k];
           }
       }
   }
   return min;
}


void h(int[,] matrix, int min)
{
   int y; int x;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int k = 0; k < matrix.GetLength(1); k++)
       {
           if (matrix[i, k] == min)
             
           y = i;
           x = k;


           if (matrix[i, k] != matrix[i, x]) //&& (matrix[i, k] != matrix[i, x]))


               System.Console.Write($"{matrix[i, k]}");




       }
       System.Console.WriteLine(" ");
   }
}


int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
int min = SearchMin(matrix);
System.Console.WriteLine(min);
h(matrix, min);
