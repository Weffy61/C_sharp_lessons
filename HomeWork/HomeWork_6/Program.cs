/*
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int NumCheck(int count)
{   
    int result = 0;
    int temp = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write("Input a number: ");
        temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) result++;
        Console.WriteLine(result);
    }
    return result;
}

Console.Write("Enter the desired number of input digits: ");
int count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Entered {NumCheck(count)} digits greater than 0");
*/

/*
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CoordinateFinder(double b1,  double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2 && b1 != b2) Console.WriteLine("The lines are parallel to each other");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("Straight lines superimposed on each other");
    else Console.WriteLine($"Straight lines intersect at {x}, {y}");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

CoordinateFinder(b1, k1, b2, k2);

*/