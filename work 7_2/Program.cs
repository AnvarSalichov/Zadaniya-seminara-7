// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] matrix = new int [3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }  
Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}");
    }  
Console.WriteLine();
}

Console.WriteLine("Введите позиции элемента в массиве 3x4:");
Console.WriteLine("номер строки - ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("номер столбца - ");
int columns=Convert.ToInt32(Console.ReadLine());
if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1))
{
    Console.WriteLine("элемент с данным адресом равен "+matrix[rows, columns]);
}
else
{
    Console.WriteLine("элемента с таким адресом в массиве нет");
}
