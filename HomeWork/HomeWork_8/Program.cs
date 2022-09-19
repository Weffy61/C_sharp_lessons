
/*
// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] RowArraySorter(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[,] arraySorted = RowArraySorter(myArray);
Show2dArray(arraySorted);

*/


/*
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void MinSum(int[,] array)
{   
    int count_row = 0;
    int minSum = 0;
    int sumRow;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow += array[i,j];
        if (i == 0)
            minSum = sumRow;
        else if (sumRow < minSum)
        {
            minSum = sumRow;
            count_row = i;
        }
    }
    Console.WriteLine($"The minimum sum of elements have {count_row + 1} line(s)");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
MinSum(myArray);

*/

/*
// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}


int[,] ArrayMult(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Matrix multiplication is not possible. The number of columns of the first matrix is not equal to the number of rows of the second matrix");
    }
        int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    array3[i, j] += array1[i, k] * array2[k, j];
                }
            }

        }
    
    return array3;
}

int[,] myArray1 = CreateRandom2dArray();
int[,] myArray2 = CreateRandom2dArray();
int[,] myArray3 = ArrayMult(myArray1, myArray2);

Show2dArray(myArray1);
Show2dArray(myArray2);
Show2dArray(myArray3);

*/

/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[] CreateRandomNum(int x, int y, int z)
{
    int[] array = new int [x * y * z];
    int num;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        num = array[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            while (array[i] == array[j])
            {
                array[i] = new Random().Next(10, 100);
                j = 0;
                num = array[i];
            }
            num = array[i];
        }
    }
    return array;
}

int[,,] Create3dArray(int[] array, int numX, int numY, int numZ)
{
    int[,,] array3D = new int[numX, numX, numZ];
    int temp = 0;
    for (int x = 0; x < numX; x++)
    {
        for (int y = 0; y < numY; y++)
        {
            for (int z = 0; z < numZ; z++)
            {
                array3D[x, y, z] = array[temp];
                temp++;
            }
        }
    }
    return array3D;

}


void Show3DArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.Write("Input number of x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] ranomArray = CreateRandomNum(x, y, z);
int[,,] array3D = Create3dArray(ranomArray, x, y, z);
Show3DArray(array3D);

*/



