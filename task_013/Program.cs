/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
           или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6         */

System.Console.WriteLine("Здравствуйте, эта программа покажет" 
                    +   " Вам третью цифру введённого Вашего числа или покажет её отсутствие,\n"
                    +   "Введите, пожалуйста, положительное число: ");
string numberEntered = Console.ReadLine();

void getThirdDigitOfNumber(string number)
{
    if (number.Length < 3) 
    {   
        System.Console.WriteLine();
        System.Console.WriteLine($"{number} -> третьей цифры нет");
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"{number} -> {number[2]}");
    }
}

getThirdDigitOfNumber(numberEntered);