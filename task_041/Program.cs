/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
              Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3     */

int[] InputNumber()
{
    int i = 0;
    int quantity = 1;

    System.Console.WriteLine($"Введите, пожалуйста, количество чисел, которые Вы хотите написать: ");
    int count = Int32.Parse(Console.ReadLine());  
    int[] number = new int[count];

    do 
    { 
        System.Console.WriteLine($"Введите, пожалуйста, {quantity} число: ");
        number[i] = Int32.Parse(Console.ReadLine());
        i++; quantity++;
        if(i == count) break;
    } while (true);
    return number;
}

void PrintNumbersGreaterZero(int[] collection)
{
    int length = collection.Length;
    int countNumbersGreaterZero = 0;

    for (int i = 0; i < length; i++)
    {
        if (collection[i] > 0) countNumbersGreaterZero++;
    }
    System.Console.WriteLine(countNumbersGreaterZero);
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    System.Console.Write("[");

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            System.Console.Write($"{collection[i]}] -> ");
            break;
        }
        System.Console.Write($"{collection[i]}, ");
    }
}

int[] array = InputNumber();
PrintArray(array);
PrintNumbersGreaterZero(array);