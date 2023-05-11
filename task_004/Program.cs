/* Задача 4: Напишите программу, которая принимает 
          на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22     */

System.Console.WriteLine("Здравствуйте, эта программа поможет" 
                    +   " Вам определить максимальное число из трёх чисел,\n"
                    +   "Введите, пожалуйста, первое число: ");
int numberFirst = int.Parse(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Введите, пожалуйста, второе число: ");
int numberSecond = int.Parse(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Введите, пожалуйста, третье число: ");
int numberThird = int.Parse(Console.ReadLine());

void getMaxNumber(int number1, int number2, int number3)
{
    int max = number1;
    if (number2 > number1) max = number2;
    if (number3 > number2) max = number3;
    System.Console.WriteLine();
    System.Console.WriteLine($"Результат: {max}");
}

getMaxNumber(numberFirst, numberSecond, numberThird);
