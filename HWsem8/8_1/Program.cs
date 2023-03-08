// Найти произведение двух матриц


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
void Multiplication(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       int p=1;
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           p = matrix[i, j] * p;
       }
       System.Console.WriteLine($"Произведение строки №{i}:");
       System.Console.WriteLine(p);
      
   }
}


int[,] matrix = new int[2, 4];
FillArray(matrix);
PrintArray(matrix);
Multiplication(matrix);
