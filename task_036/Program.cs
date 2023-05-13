/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
              Найдите сумму элементов с нечётными индексами.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0       */

int[] FillArray()
{
    int randomNumbers = new Random().Next(5, 10);
    int[] array = new int[randomNumbers];
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

void PrintArray(int[] collection)
{
    int length = collection.Length;

    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            System.Console.Write($"{collection[i]}]");
            break;
        }
        System.Console.Write($"{collection[i]}, ");
    }
}

int GetSumOfElementsWithOddIndexes(int[] collection)
{
    int length = collection.Length;
    int sum = 0;

    for (int i = 1; i < length; i += 2)
    {
            sum += collection[i];
    }
    return sum;
}

int[] collection = FillArray();
PrintArray(collection);
int SumOfElementsWithOddIndexes = GetSumOfElementsWithOddIndexes(collection);
System.Console.WriteLine($" -> {SumOfElementsWithOddIndexes}");