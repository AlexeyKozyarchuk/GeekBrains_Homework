/* Задача 2: Напишите программу, которая
             на вход принимает два числа и выдаёт, 
             какое число большее, а какое меньшее.

Пример:

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

System.Console.WriteLine("Здравствуйте, эта программа поможет" 
                    +   " Вам определить максимальное число из двух чисел,\n"
                    +   "Введите, пожалуйста, первое число: ");
int numberFirst = int.Parse(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Введите, пожалуйста, второе число: ");
int numberSecond = int.Parse(Console.ReadLine());

void getMaxNumber(int number1, int number2)
{
    int max = number1;
    if (number2 > number1) max = number2;
    System.Console.WriteLine();
    System.Console.WriteLine($"Результат: {max}");
}

getMaxNumber(numberFirst, numberSecond);
