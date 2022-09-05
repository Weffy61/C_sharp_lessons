/*
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Exponentiation(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    Console.WriteLine(res);
}

Console.Write("Input number A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());


Exponentiation(num1, num2);
*/

/*
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum(int number)
{
    // for (int i = 0; )
    int res = 0;
    int temp = number;
    while (temp > 0)
    {
        res += temp % 10;
        temp = temp / 10;
    }
    return res;
}

Console.Write("Input positive int number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSum(num));
*/



/*
// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i ++)
    {
        Console.Write($"Input a number for index {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");

}

int [] newArr = CreateRandomArray(8);
PrintArray(newArr);

*/
