/*

// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int EvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateRandomArray(size);

ShowArray(newArray);

Console.WriteLine($"Array contains {EvenNum(newArray)} even numbers");

*/


/*
// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


int SumOdNum(int[] array)
{
    int sum = 0;
    for (int i =0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }
    return sum;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.WriteLine($"The sum of the numbers at the odd index is {SumOdNum(newArray)}");
*/


/*
// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int [] MinMaxNum(int[] array)
{
    int[] minMax = new int[2];
    minMax[0] = array[0];
    minMax[1] = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minMax[0]) minMax[0] = array[i];
        else if (array[i] > minMax[1]) minMax[1] = array[i];
    }
    return minMax;
}

int Diff(int[] array) 
{
    int result = array[1] - array[0];
    return result;
}



Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);


int[] minMax = MinMaxNum(newArray);

ShowArray(minMax);

Console.WriteLine($"The difference between the maximum and minimum array elements is {Diff(minMax)}");

*/