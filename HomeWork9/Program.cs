/* Задача 1: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1 ) ShowNums(num - 1);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNums(number);
*/


/* Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
 int SumOfElements(int m, int n)
{   
    int sum = 0;
    if (m < n) 
    {
    sum = m + SumOfElements(m + 1, n);
    }
    else if (m > n) 
    {
    sum = m + SumOfElements(m - 1, n);
    }
    else sum = m;
    return sum;
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumOfElements(m, n);
Console.WriteLine($"Cумма элементов: " + result);
*/


/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
int FunctionAkkermana(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return FunctionAkkermana(n - 1, 1);
    if (n > 0 && m > 0) return FunctionAkkermana(n - 1, FunctionAkkermana(n, m - 1));
    return FunctionAkkermana(n, m);
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

FunctionAkkermana(n, m);
Console.WriteLine($"Результат: {FunctionAkkermana(n, m)}");
*/