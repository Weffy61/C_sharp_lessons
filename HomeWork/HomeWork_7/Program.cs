/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            double num = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);

            newArray[i,j] = Math.Round(num, 1);
        }

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }

    Console.WriteLine();
}



double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }

    Console.WriteLine();
}

void IndexChecker(int[,] array)
{
    Console.Write("Input row number: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Input column number: ");
    int column = Convert.ToInt32(Console.ReadLine()) - 1;
    if (row + 1 <= array.GetLength(0) && column + 1 <= array.GetLength(1))
        Console.WriteLine($"{row + 1} row {column + 1} columns contains the value {array[row, column]}");
    else Console.WriteLine("Wrong input");

}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
IndexChecker(myArray);

*/


/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(double[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }

    Console.WriteLine();
}

double[] AverageSum(int[,] array, int size)
{   
    double[] averageSum = new double[size];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            {
                averageSum[i] += array[j, i];
            }
        // averageSum[i] /= array.GetLength(0);
        averageSum[i] = Math.Round(averageSum[i] / array.GetLength(0), 1);
    }
    // Console.WriteLine(AverageSum);
    return averageSum;

}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
double[] averSum = AverageSum(myArray, myArray.GetLength(1));
ShowArray(averSum);

*/