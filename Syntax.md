# Console commands

*dotnet new console* - Создание проекта в текущем каталоге  
*dotnet run* - Компиляция и запуск проекта  

# Syntzax C#

## Обратить внимание, почти всегда необходимо писать ";", в конце каждой строки кода!!! Является признаком окончания оператора  

# Типы данных

*string* - Строковый тип  
*int* - Целые числа  
*double* - Вещественные числа(Аналог числа с плавающей точкой - float)  
*bool* - Булевое значение true/false  

# Условия

if(Условие)  
{  
 Набор действий 1  
}  
else  
{  
 Набор действий 2  
}  

*&&*- условный оператор логическое "и", аналог "and"
*^*- условный оператор логическое "или", аналог "or"

# Циклы

### While  

while(Условие продолжения)  
{  
 Набор действий  
}  


### Examples  

### For  

for (int i = 0; i < 10; i += 1)
{
    Console.WriteLine(i);
}
### Цикл в цикле  

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(i*j)
    }
    Console.WriteLine()
}

# Функции(Методы)

## С использованием return

Возвращаемый_тип_данных Имя_метода([Тип_данных_1, Имя_аргумента_1, ...])
{
 Тело метода
 return Значение_соответствующее_возвращаемому_типу_данных
}

## Без возврата результата(используем void)

void Имя_метода([Тип_данных_1, Имя_аргумента_1, ...])
{
 Тело метода
}

## Массивы

*type[] arrayName = new typeArray[size]*- Создание массива
*string[,]table = new string[2, 3]*- Создание двумерного массива типа
*int[,] matrix = new int[x, y]*- Создание двумерного массива типа, где x - строки, y - столбцы
*arrayName.GetLength(x, y)*- Функция проверки размера многомерного массива, где x - строки, y - столбцы

# Another

*/text/* - Комментирование кода  
*/*example*/ - Комемнтирование определенного участка кода  
*Console.WriteLine("Data")*- Вывод в консоль с переносом на новую строку. Аналог print()  
*Console.Write("Data")*- Вывод в консоль без переноса на новую строку  
*Console.ReadLine()*- Ввод данных. Аналог input()  
*string text*- Создание переменной 'text' со строковым типом данных  
*new Random().Next(min, max)*- Генерация псевдослучайного числа от min до max-1  
*str_var.ToLower()*- Функция замены всех букв в переменной на нижний регистр  
*str_var.ToUpper()*- Функция замены всех букв в переменной на верхний регистр  
*Console.Clear()*- Очистка консоли  
*Console.SetCursorPosition(x, y)*- установка курсора в заданных координатах, где x - отсуп от левого края, y - отступ от верхнего края  
*Convert.ToInt32(var)*- конвертация в целое 32 битное число переменной var, где var является целым числом  
*array_name.Length*- Вовзращает длинну массива array_name  
*break*- аналог break в python для прерывания цикла  
*int[] array_name = new int[n]*- Создание массива array_name с заданной длинной n, по дефолту заполнен нулями  
*Convert.ToString(int_var)*- Конвертация int в str переменной int_var  
*Math.Sqrt(var)*- Метод находит квадратный корень из переменной var  
*Math.Pow(var_1, var_2)*- Данный метод возводит var_1 в степень var_2  
