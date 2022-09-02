/* 

// Задача 1.

Console.Write("Input Integer number: ");

int number = Convert.ToInt32(Console.ReadLine());

int quad = number * number;

Console.Write($"Quad of {number} is {quad}");
*/


/* 
// Задача 2. Является ли 1-ое число квадратом 2-ого числа

Console.Write("Input 1st Integer number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd Integer number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int quad = number_2 * number_2;

if(number_1 == quad)
{
    Console.WriteLine($"{number_1} is a quad of {number_2}");
}
else
{
    Console.WriteLine($"{number_1} is not a quad of {number_2}");
}
*/

/* 
// Задача 3. На входе число N, на выходе показывает все целые числа от -N до N

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current += 1;
}
*/


/* 
// Задача 4. На входе принять 3-х значное число, на выходе показать последнюю цифру данного числа

Console.Write("Input three-digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.WriteLine($"Last digit if {num} is {result}");

*/

