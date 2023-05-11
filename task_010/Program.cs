/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
           и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1       */

System.Console.WriteLine("Здравствуйте, эта программа покажет" 
                    +   " Вам вторую цифру введённого Вашего трёхзначного числа,\n"
                    +   "Введите, пожалуйста, положительное трёхзначное число: ");
string numberEntered = Console.ReadLine();

void getSecondDigitOfNumber(string numberThreeDigit)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"Вторая цифра ---> {numberThreeDigit[1]}");
}

getSecondDigitOfNumber(numberEntered);