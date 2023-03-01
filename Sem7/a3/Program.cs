// В прямоугольной матрице найти строку
//с наименьшей суммой элементов.


int[,] matrix = new int[5, 2];


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
Sam(matrix);


void Sam(int[,] array)
{
   int sum;
   int max = 0;
   int d;
   for (int i = 0; i < array.GetLength(0); i++)
   {
       sum = 0;


       System.Console.WriteLine(" ");
       for (int k = 0; k < array.GetLength(1); k++)
       {
           sum = array[i, k] + sum;


           if (sum > max)
           {
               max = sum;
               d = i;
           }
       }
  
   System.Console.WriteLine($"сумма столбца {i} = {max}");
}}


