/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.WriteLine("Введите координату строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void FindPosition(double[,] array)
{
    if (rows > array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.Write($"{rows},{columns} -> такого числа в массиве нет ");
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == rows)
            {
                if (j == columns)
                {
                    Console.Write($"{array[i, j]} ");
                }
            }
        }
    }
}
double[,] matrix = new double[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
FindPosition(matrix);