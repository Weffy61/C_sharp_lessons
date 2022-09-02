/* 
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input 1st Integer number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd Integer number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 >= number_2)
{
    Console.WriteLine($"max =  {number_1}");
}
else
{
    Console.WriteLine($"max =  {number_2}");
}
*/



/* 
// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input 1st Integer number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd Integer number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd Integer number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;
if (number_2 > number_1)
{
    max = number_2;
}
    
if (number_3 > max)
{
    max = number_3;
}

Console.WriteLine($"max = {max}");
*/



/* 
// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input Integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"The number {num} is an even number");
}
else
{
    Console.WriteLine($"The number {num} is an odd number");
}
*/



/* 
// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input Integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num)
{
    Console.Write(current + " ");
    current += 2;
}
*/

