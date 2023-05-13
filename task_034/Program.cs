/* Задача 34:   Задайте массив заполненный случайными положительными трёхзначными числами.
                Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2       */

int[] FillArray()
{
    int randomNumbers = new Random().Next(5, 20);
    int[] array = new int[randomNumbers];
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
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

int GetSumEvenNumbers(int[] collection)
{
    int length = collection.Length;
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        if (collection[i] % 2 == 0) sum++;
    }
    return sum;
}

int[] collection = FillArray();
PrintArray(collection);
int sumEvenNumbers = GetSumEvenNumbers(collection);
System.Console.WriteLine($" -> {sumEvenNumbers}");