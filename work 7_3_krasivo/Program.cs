// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix = new int [2,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j]+" ");
        //Console.Write($"{matrix[i,j]+" "}");
    }  
Console.WriteLine();
}

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    double sredn=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum+matrix[i,j];
    }
    Console.WriteLine("сумма столбца "+j+" = "+sum);
    sredn=sum/matrix.GetLength(0);
    Console.WriteLine("среднее арифметическое столбца "+j+" = "+sredn);
    sum=0;
    sredn=0;
}