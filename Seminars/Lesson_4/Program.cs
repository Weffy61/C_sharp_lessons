/*
// Задача 1. Принимает на вход некоторое число и выдает сумму чисел от 1 до входящего числа

int FindSum(int a)
{
    int sum = 0;

    for (int current = 1; current <= a; current++)
    {
        sum += current;
    }
    return sum;
}

Console.Write("Input positive int number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");
*/

/*
// Задача 2. Принимает на вход число и возвращает колличество цифр в этом числе.

int FindLen(int number)
{
    int temp = number;
    int length = 0;
    while (temp != 0)
    {
        temp = temp / 10;
        length += 1;
    }
    return length;
}

Console.Write("Input positive int number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindLen(num));
*/

/*
// Задача 3. Принимает на вход число и возвращает факториал этого числа

int Factorial(int number)
{
    int tempNumber = 1;
    int counter = number;
    while(counter != 0)
    {
        tempNumber *= counter;
        counter -= 1;
    }
    return tempNumber;
}

Console.Write("Input positive int number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(num));
*/


// Задача 4. Вывод массива из 8 элементом, заполненого нулями и еденицами в случайном порядке

int[] CreateRandomArray(int n, int minVal, int maxVal)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i ++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
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

int [] newArr = CreateRandomArray(8, 0, 1);
PrintArray(newArr);