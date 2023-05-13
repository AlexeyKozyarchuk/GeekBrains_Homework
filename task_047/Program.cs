/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5      7      -2      -0,2

 1     -3,3      8      -9,9

 8      7,8    -7,1       9     */

 double[,] FillArray2D()
 {
    int numberRow = new Random().Next(3, 6);
    int numberColumn = new Random().Next(3, 6);
    double[,] array2D = new double[numberRow, numberColumn];
    Random rand = new Random();
    int numberRandom = 0;

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            numberRandom = new Random().Next(-100, 100);
            array2D[i, j] = Math.Round(rand.NextDouble() * numberRandom, 2);
        }
    }
    return array2D;
 }

void PrintArray2D(double[,] collection)
{
    System.Console.WriteLine();
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            System.Console.Write($"{collection[i,j]}   ");
        }
        System.Console.WriteLine("\n");
    }
}

double[,] array2D = FillArray2D();
PrintArray2D(array2D);