/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
              заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)    */

double pointB1 = 0, pointK1 = 0, 
       pointB2 = 0, pointK2 = 0;
int indexArray0 = 0;

int PrintDescription(int indexArray)
{
    string[] array = new string[]{"b1", "k1", "b2", "k2"};

    System.Console.WriteLine($"Введите значение точки {array[indexArray]}: ");
    indexArray++;
    System.Console.WriteLine();
    return indexArray;
}

double SetValueOfPoint(double point)
{
    point = Double.Parse(Console.ReadLine());
    return point;
}

int indexArray1 = PrintDescription(indexArray0);
pointB1 = SetValueOfPoint(pointB1);
int indexArray2 = PrintDescription(indexArray1);
pointK1 = SetValueOfPoint(pointK1);
int indexArray3 = PrintDescription(indexArray2);
pointB2 = SetValueOfPoint(pointB2);
int indexArray4 = PrintDescription(indexArray3);
pointK2 = SetValueOfPoint(pointK2);

void GetCoordinatesOfIntersectionPoint(double pointB1, double pointK1, double pointB2, double pointK2)
{   
    double x = 1, y;
 
    double xMediocre = pointK1 - pointK2;
    x =  (pointB2 - pointB1) / xMediocre;
    y = pointK1 * x + pointB1;

    System.Console.WriteLine($"({x}, {y})");
}

GetCoordinatesOfIntersectionPoint(pointB1,  pointK1,  pointB2,  pointK2);