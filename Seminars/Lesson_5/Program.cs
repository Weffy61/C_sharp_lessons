/*
// Задача 1. Задать массив из 12 элементов, заполненный случайными числами из промежутка от -9 до 9. Найти сумму отрицательных элементов массива.

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

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];

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

Console.Write($"Sum of negative elements is {FindNegativeSum(newArray)}");
*/


/*
// Задача 2. Замена элементов в массиве: положительные элементы заменить на отрицательные, и наоборот.


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


int [] ArrayChanger(int[] array, int size)
{
    for (int i = 0; i < array.Length; i++)
    {   
        array[i] = array[i] * (-1);
    }
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
int [] chanArray = ArrayChanger(newArray, size);
ShowArray(chanArray);
*/


/*
// Задача 3.  Задать массив. Определить присутствует ли заданное число в массиве.


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

bool ArrayChecker(int[] array, int number) 
{
    bool check = false;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number) 
            {
                check = true;
            }
        }
    return check;
}

void ShowChecker(int [] array, int num)
{
    if (ArrayChecker(array, num))
{
    Console.WriteLine("Number was found");
}
    else  Console.WriteLine("Number was not found");
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number for check in array: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);

ShowArray(newArray);
ShowChecker(newArray, num);

*/



/*
// Задача 4. Задать одномерный массив из 15 случайных чисел, Найти колличество эллементов массива, значения которых лежат в отрезке [10.99].


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

int Counter(int[] array, int minNum, int maxNum)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > minNum) && (array[i] < maxNum)) count++;
        }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min range number for check in array: ");
int numMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max range number for check in array: ");
int numMax = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);

ShowArray(newArray);

Console.WriteLine($"In array was found {Counter(newArray, numMin, numMax)} element(s)");

*/



/*

// Задача 5. Найти произведение пар чисел в массиве. Парой считается 1-ый и последний элемент, 2-ой и предпоследний и т.п. Результат записать в новом массиве


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

int[] MultArray(int[] array)
{
    int len = array.Length;
    int[] result = new int [(len/2) + len % 2];
    for (int i = 0; i < (len / 2) + (len % 2); i++)
        result[i] = array[i] * array[(len - i - 1)];
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

int[] result = MultArray(newArray);
ShowArray(result);

*/