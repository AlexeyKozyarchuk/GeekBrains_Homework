/* Задача 8: Напишите программу, которая на вход принимает число (N),
             а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8      */

System.Console.WriteLine("Здравствуйте, эта программа покажет" 
                    +   " Вам чётные числа от 0 до введённого Вашего числа,\n"
                    +   "Введите, пожалуйста, число: ");
int numberEntered = int.Parse(Console.ReadLine());

System.Console.WriteLine();

void getArrayEven(int collection)
{
    int numberEven = 2;
    while(numberEven <= collection)
    {
        if ((numberEven == collection) || (numberEven == collection - 1))
        {
            System.Console.WriteLine(numberEven);
            break;
        }
        System.Console.Write($"{numberEven}, ");
        numberEven += 2;
    }
}

getArrayEven(numberEntered);







// int[] array = new int[numberEntered];
// void getArrayEven(int[] collection)
// {
//     int length = collection.Length;
//     int numberFalse = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if ((collection[i] % 2) == numberFalse)
//         {
//             if (i == length - 1) 
//             {
//                 System.Console.Write(collection[i]);
//                 break;
//             }
//             System.Console.Write($"{collection[i]}, ");
//         }
//     }
// }

// getArrayEven(array);