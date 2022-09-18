// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] array = new int [4,4];
Random rnd = new Random();
for(int i = 0; i < array.GetLength(0); i++)
{
   
   for(int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j] = rnd.Next(10,20);
      Console.Write(array[i,j] + " ");
   }
   Console.WriteLine();
}
int sum = 0;
int sum1 = 0;
int sum2 = 0;
int row = 0;

for(int i = 0; i < array.GetLength(0); i++)
{
   sum2 = 0;
   for(int j = 0; j < array.GetLength(1); j++)
   {
      sum2 += array[i, j];
   }  
      if (sum2 < sum1)
      {
         sum = sum2;
         row = i;
      }
      sum1 = sum2;
}
Console.WriteLine($"Наименьшая сумма равна {sum}");
Console.WriteLine($"Строка с наименьшей суммой {row}");