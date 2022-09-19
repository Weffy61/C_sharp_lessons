/*
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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


int [,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[row1, j];
        array[row1,j] = array[row2,j];
        array[row2,j] = temp;
    }

    return array;
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Show2dArray(ChangeRows(myArray, 2, 5));

*/

/*
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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


int[,] RowColChanger(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {   
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j,i] = temp;
            }
    else Console.WriteLine("Incorrect array");
    return array;

}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[,] changedArray = RowColChanger(myArray);
Show2dArray(changedArray);

*/

/*
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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


int[] MinValueFinder(int[,] array)
{
    int [] minPos = {0, 0};
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minPos[0], minPos[1]])
            {
                minPos[0] = i;
                minPos[1] = j;
            }
    return minPos;
}

int[,] NewArray(int[,] array, int row, int col)
{
    int [,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    int counterRow = 0;
    int counterColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   counterColumn = 0;
        if (i == row)
        {
            counterRow = 1;
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (j == col)
        {
            counterColumn = 1;
            continue;
        }
        newArray[i-counterRow,j-counterColumn] = array[i, j];
        } 
    }
    return newArray;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int [] minValue = MinValueFinder(myArray);
int[,] newArray = NewArray(myArray, minValue[0], minValue[1]);
Show2dArray(newArray);
*/
