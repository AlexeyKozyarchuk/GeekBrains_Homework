/* Задача 21:   Напишите программу, которая принимает на вход координаты двух точек
                и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53       */

 void getDistance3DSpaces()
{
    System.Console.WriteLine("Здравствуйте, эта программа расчитает"
            +   " Вам расстояние в 3D пространстве между двумя точками,"
            +   " Вам нужно ввести 3 координаты каждой точке.\n"
            +   "Введите, пожалуйста, координаты точки А(пример: 341, где 3 -> x, 4 -> y, 1 -> z): ");
    string numberA = Console.ReadLine();

    System.Console.WriteLine("Введите, пожалуйста, координаты точки B(пример: 571, где 5 -> x, 7 -> y, 1 -> z): ");
    string numberB = Console.ReadLine();

    double resultIntermediate = ((numberB[0] - numberA[0]) * (numberB[0] - numberA[0])) 
                  + ((numberB[1] - numberA[1]) * (numberB[1] - numberA[1])) 
                  + ((numberB[2] - numberA[2]) * (numberB[2] - numberA[2]));
    double resultEnd = Math.Pow(resultIntermediate, 0.5);
    
    System.Console.WriteLine($"\nA ({numberA[0]},{numberA[1]},{numberA[2]}); " +
                             $"B ({numberB[0]},{numberB[1]},{numberB[2]}), -> {resultEnd}");
}

getDistance3DSpaces();