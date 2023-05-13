/* Задача 38:       Задайте массив вещественных чисел. 
                    Найдите разницу между максимальным и минимальным элементами массива.

[3,21 7,04 22,93 -2,71 78,24] -> 80,95     */

// !!! ЗАДАЧА СПИСАНА И ПЕРЕДЕЛАНА С ИСТОЧНИКА: https://blablacode.ru/c_code/1442

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] arrayRandom = new double[number];

void FillArray(int number)
{
    Random rand = new Random();
    System.Console.Write($"[");
    for (int i = 0; i < number; i++)
    {
        arrayRandom[i] = Math.Round(rand.NextDouble() * 1000, 2);
        if (i == number - 1)
        {
            System.Console.WriteLine($"{arrayRandom[i]}]");
            break;
        }
        Console.Write($"{arrayRandom[i]}, ");
    }
}

double GetDifferenceMaxAndMin(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max<randomArray[i]) max = randomArray[i];
        if (min>randomArray[i]) min = randomArray[i];
        i = i + 1;
    }
    return max-min;
}

FillArray(number);
Console.Write($"\nРазница между Max и Min -> {GetDifferenceMaxAndMin(arrayRandom):F2}");
