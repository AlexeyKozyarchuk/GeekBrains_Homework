/* Задача 25:       Напишите цикл, который принимает на вход два числа (A и B)
                    и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16   */

void raiseOneNumberToAnother()
{
    System.Console.WriteLine("Здравствуйте, эта программа"
            +   " для Вас возведёт первое число в степень второго числа,"
            +   "\nВведите, пожалуйста, первое число(основание степени): ");
    int numberFirst = int.Parse(Console.ReadLine());

        System.Console.WriteLine("\nВведите, пожалуйста, второе число(показатель степени): ");
    int numberSecond = int.Parse(Console.ReadLine());

    double result = Math.Pow(numberFirst, numberSecond);
    System.Console.WriteLine($"{numberFirst}, {numberSecond} -> {result}");
}

raiseOneNumberToAnother();