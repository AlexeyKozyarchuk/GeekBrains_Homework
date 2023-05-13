/* Задача 50.    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
                 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет     */

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

void GetValueOfElement(double[,] collection)
{
    System.Console.Write("Введите номер строки: ");
    int numberRow = Int32.Parse(Console.ReadLine());
    System.Console.Write("Введите номер столбца: ");
    int numberColumn = Int32.Parse(Console.ReadLine());
    try
    {
        if ((numberRow <= collection.GetLength(0)) && (numberColumn <= collection.GetLength(1))) 
        {
            System.Console.WriteLine(collection[numberRow - 1, numberColumn - 1]);
        }
        else
        {
            System.Console.WriteLine("Такого числа нет в массиве");
        }
    }
    catch (System.IndexOutOfRangeException)
    {
        System.Console.WriteLine("Такого числа нет в массиве");
    }

}

double[,] array2D = FillArray2D();
PrintArray2D(array2D);
GetValueOfElement(array2D);