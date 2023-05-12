/* Задача 27: Напишите программу, которая принимает на вход
              число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12        */

//НЕ МОГУ ПОНЯТЬ ПОЧЕМУ ОШИБКА !!!

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
        int count = Convert.ToInt32(numberEntered[i]);
        sum += count;
    }
    System.Console.WriteLine(sum);
}

getSumOfDigitsInNumber();