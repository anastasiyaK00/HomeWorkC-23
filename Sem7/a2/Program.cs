// Написать программу, упорядочивания по убыванию
//элементы каждой строки двумерной массива.
int[,] matrix = new int[4, 5];


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
sort(matrix);
System.Console.WriteLine("массив отсортированный: ");
PrintArray(matrix);
void sort(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
 {
   for (int j = 0; j < array.GetLength(1); j++)
   {
     for (int k = 0; k < array.GetLength(1) - 1; k++)
     {
       if (array[i, k] < array[i, k + 1])
       {
         int temp = array[i, k + 1];
         array[i, k + 1] = array[i, k];
         array[i, k] = temp;
       }
     }
   }
 }
}


