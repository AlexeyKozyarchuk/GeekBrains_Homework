/* Задача 23: Напишите программу, которая принимает на вход число (N)
              и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125          */


void getNumbersCup()
{
    System.Console.WriteLine("Здравствуйте, эта программа покажет"
            +   " Вам числа в кубе от 1 до введённого Вами числа,"
            +   "\nВведите, пожалуйста, число: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    for (int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 3);
        if (i == number)
        {
            System.Console.Write(result);
            break;
        }
        System.Console.Write($"{result}, ");
    }
}

getNumbersCup();