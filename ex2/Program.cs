// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.

//заполнение первой матрицы
int [,] matrix1 = new int [4,4];
Random r = new Random();

for(int i = 0; i < matrix1.GetLength(0); i++)
{
   for(int j = 0; j < matrix1.GetLength(1); j++)
   {
      matrix1[i, j] = r.Next(10, 50);
      Console.Write(matrix1 [i, j] + " ");
   }
   Console.WriteLine();
}

// заполнение второй матрицы
int [,] matrix2 = new int [4,4];
Random rnd = new Random();

for(int i = 0; i < matrix2.GetLength(0); i++)
{
   for(int j = 0; j < matrix2.GetLength(1); j++)
   {
      matrix2[i, j] = rnd.Next(10, 50);
      Console.Write(matrix2 [i, j] + " ");
   }
   Console.WriteLine();
}

//подсчет произведения матриц
int Multiply(int [,] matrix1, int [,] matrix2)
{
   if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
   { 
      Console.WriteLine("Матрицы перемножить невозможно"); 
   }
 
   int ma = matrix1.GetLength(0);
   int mb = matrix2.GetLength(0);
   int nb = matrix2.GetLength(1);
 
   int[,] array = new int [ma, nb];
 
   for (int i = 0; i < ma; i++)
   {
      for (int j = 0; j < nb; j++)
      {
         for (int k = 0; k < mb; k++)
         {
            array[i, j] += matrix1[i, k] * matrix2[k, j];
         }
      }
   }
   return array;
}