/* 

// Задача 1. Вывод случайного числа из отрезка от 10 до 99 и показывает наибольшую цифру заанного числа.

int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int result;
    if(ed > dec) result = ed;
    else result = dec;

    // Аналогично:
    // if(ed > dec) return ed;
    // else return dec;

    return result;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");

*/



/* 
// Задача 2. Выводит случайное трехзначное число и удаляет 2-ую цифру этого числа.

int twoDigit(int number)
{
    int num_1 = (number / 100) * 10;
    int num_2 = number % 10;
    int result = num_1 + num_2;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int result = twoDigit(randNumber);

Console.WriteLine($"Three-digit number is {randNumber}, two-digit number is {result}");
*/



/* 
// Задача 3. Принимает на вход 2 числа и выводит является ли 2-ое число кратным 1-ому. Если 2-ое не кратно 1-ому, то должен быть выведен остаток от деления. Через void.

void Function(int num_1, int num_2)
{
    if (num_2 % num_1 == 0)
    {
        Console.WriteLine($"{num_2} is a multiple of {num_1}");
    }
    else Console.WriteLine(num_2 % num_1);
}

Console.Write("Input 1st Integer number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd Integer number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Function(number_1, number_2);

*/


/* 
// Задача 4. Принимает на вход число и проверяет кратно ли оно 7 и 23. 7 и 23 являются аргументами метода.

bool Checker(int inputNum, int defaultNum1, int defaultNum2)
{
    if ((inputNum % defaultNum1 == 0) & (inputNum % defaultNum2 == 0)) 
    {
        return true;
    }
    else return false;
}

Console.Write("Input Integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Checker(num, 7, 23);
Console.WriteLine(result);
*/


// Задача 5. Принимает на вход 2 числа и проверяет является ли одно число квадратом другого.

