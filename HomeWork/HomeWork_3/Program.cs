/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void PalChecker(int num)
{
    int numForCheck = num; // Делаем копию введенного числа для сравнения
    int reverseNum = 0; // Задаем переменную для перевернутого числа
    while(num > 0)
    {
        int lastNum = num % 10; // Получаем последнюю цифру числа
        reverseNum = reverseNum * 10 + lastNum; // добавляем последнюю цифру в reverseNum для разворота числа
        num = num / 10; // убираем последнюю цифру из числа
        
    }
    if (numForCheck == reverseNum) Console.WriteLine("The entered number is a palindrome");
    else Console.WriteLine("The entered number is not a palindrome");
}

Console.Write("Input number for check: ");
int number = Convert.ToInt32(Console.ReadLine());
PalChecker(number);
*/

/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


void FindLen(double xa, double ya, double za, double xb, double yb, double zb)
{
    double cat_1 = xb - xa;
    double cat_2 = yb - ya;
    double cat_3 = zb - za;
    double len = Math.Sqrt(cat_1 * cat_1 + cat_2 * cat_2 + cat_3 * cat_3);
    Console.WriteLine("Len is " + len);
}


Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

FindLen(x1, y1, z1, x2, y2, z2);

*/


/*
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void QuadFunc(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count += 1;
    }
}

Console.Write("Input a numer: ");
int quad = Convert.ToInt32(Console.ReadLine());
QuadFunc(quad);

*/