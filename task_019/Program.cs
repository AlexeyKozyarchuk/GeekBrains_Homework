/* Задача 19: Напишите программу, которая принимает на вход пятизначное число 
              и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да      */

void isPalindrome()
{
    System.Console.WriteLine("Здравствуйте, эта программа ответит"
            +   " Вам на вопрос является ли введённое пятизначное число палиндромом,\n"
            +   "Введите, пожалуйста, пятизначное число: ");
    string numberEntered = Console.ReadLine();
    int length = numberEntered.Length;
    int index = -1;
        if (numberEntered[index + 1] == numberEntered[length - 1]);
        if (numberEntered[index + 1] == numberEntered[length - 1]) System.Console.WriteLine($"\n{numberEntered} -> да");
        else System.Console.WriteLine($"\n{numberEntered} -> нет");
}

isPalindrome();