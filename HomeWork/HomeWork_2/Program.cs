/* 
// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int TwoDigit(int number)
{
    int result = (number % 100) / 10;
    return result;
}

Console.Write("Input three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int secNum = TwoDigit(num);

Console.WriteLine(secNum);
*/


/*

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Checker(int num)
{
    if (num > 99)
   {
      string numToStr = Convert.ToString(num);
      Console.WriteLine(numToStr[2]);
   }
   else
   {
       Console.WriteLine("The third digit is missing");
   }
}

Console.Write("Input Integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Checker(number);
 */



/* 
// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekender(int num)
{
    if (num < 6)
    {
        Console.WriteLine("Working day");
    }
    else Console.WriteLine("Day off");
}

Console.Write("Input the number of the day of the week: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

Weekender(dayNum);
*/