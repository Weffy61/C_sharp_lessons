/*
// 1. Задайте значение N. Выведите все натуральные числа в промежутке от 1 до N.

void ShowNums(int n)
{
    if (n > 1) ShowNums(n-1);

    Console.Write(n + " ");
}

ShowNums(5);
*/

/*
// 2. Принять на вход числа и возвращать сумму его цифр

int SumOfDigits(int n)
{
    if (n > 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(5734));
*/

/*
// 3. Задать значение M и N. Вывести все натуральные числа в промежутке от M до N. 
void ShowNums(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) ShowNums(m + 1, n);
    else if (m > n) ShowNums(m - 1, n);

    
}
ShowNums(1, 10);
*/

/*
// 4.  Принять на вход 2 числа А и B, и возвести числа А в степень В с помощью рекурсии.

// #1
double MultDigits(double a, double b)
{
   
    if (b < 0)
    {
        a = 1 / a;
        b = -b;
    }
    if (b != 0) return MultDigits(a, b-1) * a;
    else return 1;
}

Console.WriteLine(MultDigits(2, -5));

// #2

double MultDigits(int a, int b)
{
    if (b >= 1) return MultDigits(a, b-1) * a;
    if (b <= -1) return MultDigits(a, b+1) /a;
    return 1.0;
}
Console.WriteLine(MultDigits(2, -5));

*/