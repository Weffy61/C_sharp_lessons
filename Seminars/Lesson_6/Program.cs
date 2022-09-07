/*
// Задача 1. Перевернуть одномерный массив(последний элемент будет на 1-ом месте, а 1-ый на последнем и т.д)

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

int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
ShowArray(ReverseArray(newArray));
*/


/*
// Задача 2. Преобразовать десятичное число в двоичное

string Converter(int num)
{
    int temp = num;
    string result = String.Empty;
    while (temp > 0)
    {
        // Console.WriteLine($"{temp}, {result}");
        result = result + Convert.ToString(temp % 2);
        temp = temp / 2;
    }
    return result;
}

Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = new string(Converter(num).ToCharArray().Reverse().ToArray());

Console.WriteLine(result);
*/


/*
// Задача 3. Не используя рекурсию вывести первые N чисел Фибоначчи. 1-ые 2 числа Фибонначи: a и b. F(i) = F(i - 1) + F(i-2). 3 аргумента это a и b, и n - колличество иттераций


void ShowArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


int[] Fibo(int a, int b, int n)
{
    int [] result = new int[n];
    result[0] = a;
    result[1] = b;
    for (int i = 2; i < n; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}


Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max iterations: ");
int max = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibo(a, b, max));
*/


/*
// Задача 4. Принимать на вход 3 числа и проверять, может ли существовать треугольник со сторонами такой длинны. <Каждая сторона треугольника строго меньше суммы 2-ух других сторон>


bool Check (int a, int b, int c)
{
    return (a+b) > c && (a+c) > b && (b + c) > a;
}

Console.Write("Input length of the first side of the triangle: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of the second side of the triangle: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of the third side of the triangle: ");
int c = Convert.ToInt32(Console.ReadLine());

if (Check(a, b, c))
    Console.WriteLine("The triangle exists");
else 
    Console.WriteLine("The triangle does't exists");
    
*/