/* Задача 15: Напишите программу, которая принимает на вход цифру, 
           обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет       */

void isWeekend()
{
    System.Console.WriteLine("Здравствуйте, эта программа ответит"
            +   " Вам на вопрос является ли введённое число выходным днём,\n"
            +   "Введите, пожалуйста, число от 1 до 7 (включительно): ");
    int dayOfWeek = int.Parse(Console.ReadLine());
    if ((dayOfWeek == 6 || dayOfWeek == 7))
    {
        System.Console.WriteLine($"\n{dayOfWeek} -> да");
    }
    if ((dayOfWeek == 1) || (dayOfWeek == 2) || (dayOfWeek == 3) ||(dayOfWeek == 4) || (dayOfWeek == 5))
    {
        System.Console.WriteLine($"\n{dayOfWeek} -> нет");
    }
    else
    {
        System.Console.WriteLine($"\n{dayOfWeek} -> Вы ввели недопустимое значение");
    }
}

isWeekend();