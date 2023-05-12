/* Задача 27: Напишите программу, которая принимает на вход
              число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12        */

void getSumOfDigitsInNumber()
{
    System.Console.WriteLine("Здравствуйте, эта программа найдёт сумму"
            +   " цифр в заданном числе,"
            +   "\nВведите, пожалуйста, целое положительное число: ");
    string numberEntered = Console.ReadLine();

    int length = numberEntered.Length;
    int sum = 0;

    System.Console.WriteLine(length);
    for (int i = 0; i < length; i++)
    {
        char count = Convert.ToChar(numberEntered[i]);
        int bar = (int)Char.GetNumericValue(count);
        sum += bar;
    }
    System.Console.WriteLine(sum);
}

getSumOfDigitsInNumber();