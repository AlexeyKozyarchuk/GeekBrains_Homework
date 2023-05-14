/* Задача 52.   Задайте двумерный массив из целых чисел. 
                Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.      */

 int[,] FillArray2D()
 {
    int numberRow = new Random().Next(3, 7);
    int numberColumn = new Random().Next(3, 7);
    int[,] array2D = new int[numberRow, numberColumn];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 10);
        }
    }
    return array2D;
 }

 double[] GetArithmeticMeanOfColumn(int[,] collection)
 {
    double sumOfColumnContents = 0;
    double[] arithmeticMeanOfColumnContents = new double[collection.GetLength(1)];
    int i = 0;

    for (int j = 0; j < collection.GetLength(1); j++)
    {
        for (int n = 0; n < collection.GetLength(0); n++)
        {
            sumOfColumnContents += collection[i + n, j];
        }
        arithmeticMeanOfColumnContents[j] = Math.Round(sumOfColumnContents / collection.GetLength(0), 3);
        sumOfColumnContents = 0;

    }
    return arithmeticMeanOfColumnContents;
 }

void PrintArray2D(int[,] collection)
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

void PrintArray(double[] collection)
{
    int length = collection.Length;
    System.Console.Write($"Среднее арифметическое каждого столбца: ");

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            System.Console.Write($"{collection[i]}.");
            break;
        }
        System.Console.Write($"{collection[i]}; ");
    }
}

int[,] array2D = FillArray2D();
PrintArray2D(array2D);
double[] number = GetArithmeticMeanOfColumn(array2D);
PrintArray(number);
