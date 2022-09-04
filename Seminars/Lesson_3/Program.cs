// Задача 1. Принимаем на вход координаты точек x, y(должно быть не нулевыми) и вернет номер четверти плоскости в которой находится эта точка.

/*
int FindQuadrant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());


int quadrand = FindQuadrant(xA, yA);
Console.WriteLine($"Number of quadtant is {quadrand}");
*/


// Задача 2. По заданному номеру четверти покажет диапазон возможных координат точек в этой четверти. На вход int, на выход str.

/*
void FindCoord(int quadrate)
{
    if (quadrate == 1) Console.WriteLine("x > 0, y > 0");
    if (quadrate == 2) Console.WriteLine("x < 0, y > 0");
    if (quadrate == 3) Console.WriteLine("x < 0, y < 0");
    if (quadrate == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Incorrent entry");
}
Console.Write("Input Quadrant 1 - 4: ");
int quad = Convert.ToInt32(Console.ReadLine());
FindCoord(quad);
*/



// Задача 3. Принимает на вход число и выдает ряд чисел квадратов от 1 до этого числа.

/*
void QuadFunc(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.Write($"{Math.Pow(count, 2)}, ");
        count += 1;
    }
}

Console.Write("Input a numer: ");
int quad = Convert.ToInt32(Console.ReadLine());
QuadFunc(quad);
*/




// Задача 4. Принимает на вход координаты 2-х точек и находит расстояние между ними на плоскости. 4 аргумента.

/*
void FindLen(double xa, double ya, double xb, double yb)
{
    double cat_1 = xb - xa;
    double cat_2 = yb - ya;
    double len = Math.Pow(cat_1 * cat_1 + cat_2 * cat_2, 0.5);
    Console.WriteLine("Len is " + len);
}


Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

FindLen(x1, y1, x2, y2);
*/