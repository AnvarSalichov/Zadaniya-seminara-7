// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите количество строчек ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов ");
int columns=Convert.ToInt32(Console.ReadLine());

double [,] matrix=new double[rows,columns]; 
for (int i = 0; i < rows; i++)
{
    for (int j= 0; j < columns; j++)
    {
       matrix [i,j]=new Random().Next(-9,10)+new Random().NextDouble();
       matrix[i,j] = Math.Round(matrix[i,j], 2);
       Console.Write(matrix[i,j]+" "); 
    }
    Console.WriteLine();
}
