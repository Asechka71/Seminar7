/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void AverageColumns (int [,] array1)
{
    int sum1 = array1 [0,0]+ array1 [1,0]+array1 [2,0]+array1 [3,0];
    int sum2 = array1 [0,1]+ array1 [1,1]+array1 [2,1]+array1 [3,1];
    int sum3 = array1 [0,2]+ array1 [1,2]+array1 [2,2]+array1 [3,2];
    int sum4 = array1 [0,3]+ array1 [1,3]+array1 [2,3]+array1 [3,3];

    Console.WriteLine($"Среднее арифметическое каждого столбца: {(double)sum1/4}, {(double)sum2/4}, {(double)sum3/4}, {(double)sum4/4}");
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
AverageColumns(matrix);
Console.WriteLine();