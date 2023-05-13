/* Задача 29:      Напишите программу, которая задаёт массив из 
                   8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33       -> [6, 1, 33]            */

int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;

    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            System.Console.Write($"{collection[i]}");
            break;
        }
        System.Console.Write($"{collection[i]}, ");
    }
}

FillArray(array);
PrintArray(array);