/*
// Задача 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) ShowNums(m + 1, n);
    else if (m > n) ShowNums(m - 1, n);

    
}
ShowNums(1, 10);
Console.WriteLine();
ShowNums(10, 1);

*/

// Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumOfDigits(int m, int n)
{

    if (m <= n) 
    {   
        return SumOfDigits(m, n-1) + n;
    }
    else return 0;
}

Console.WriteLine(SumOfDigits(1, 15));

*/

/*
// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akker(m-1, 1);
    else if (m > 0 && n > 0) return Akker(m-1, Akker(m, n-1));
    return 0;
}

Console.WriteLine(Akker(3, 2));

// Вопрос: "Почему в тестах написано m = 2, n = 3 -> A(m,n) = 29, если получается 9, если поменять местами m и n, тогда все сходится"
// https://ru.hexlet.io/challenges/intro_to_programming_ackermann_exercise - отсюда бралась формула и тут написано, что m = 2, n = 3 -> A(m,n) = 9
*/