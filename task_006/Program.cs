/* Задача 6: Напишите программу, которая на вход принимает число
          и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет     */

System.Console.WriteLine("Здравствуйте, эта программа поможет" 
                    +   " Вам определить является ли число чётным или нечётным,\n"
                    +   "Введите, пожалуйста, число: ");
int numberEntered = int.Parse(Console.ReadLine());

System.Console.WriteLine();

void isNumberEven(int number)
{
    int numberFalse = 0;
    if ((number % 2) == numberFalse) System.Console.WriteLine($"Число {number} - чёткое");
    else System.Console.WriteLine($"Число {number} - нечёткое");
}

isNumberEven(numberEntered);




                                                    // Не баг, а фича.