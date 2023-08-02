/*
Задача 1: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void ArrangesMin(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = 0; k < array.GetLength(1) - j - 1; k++) 
            {   
                if(array[i, k] < array[i, k + 1]) 
                { 
                    int temp = array[i, k]; 
                    array[i, k] = array[i, k + 1]; 
                    array[i, k + 1] = temp; 
                }    
            }
        }
    }
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);
ArrangesMin(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/


/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ", - 5);
        }
        Console.WriteLine();
    }
}
void SumMin(int[,] array)
{
    int number = 1;
    int result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = result + array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (result > sum)
        {
            result = sum;
            number++;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {number} ");
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int start = GetInput("Введите начало диапазона значений элементов: ");
int finish = GetInput("Введите конец диапазона значений элементов: ");
int[,] array = Create2dArray(m, n, start, finish);
Console.WriteLine($"Сгенерирован массив [{m}x{n}] в диапазоне от {start} до {finish} !");
Show2dArray(array);
SumMin(array);
*/


/*
Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j]+ " ");

        Console.WriteLine();
    }
}

int[,] CreateMultipleArrays(int[,] firstArray, int[,] secondArray)
{   
    if (firstArray.GetLength(0) != secondArray.GetLength(1)) 
    {
        Console.WriteLine("Нельзя перемножить матрицы ");
    }
    int[,] array = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for(int k = 0; k < secondArray.GetLength(0); k++)
            {
                array[i,j] = firstArray[i,k] * secondArray[k,j];
            }
        }
    }
    return array;
}   

Console.Write("Input a number of the first array rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the first array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of the first array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of the first array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second array rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second array columns: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of the second array: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of the second array: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
int[,] myArray2 = CreateRandom2dArray(rows2, columns2, minValue2, maxValue2);
Show2dArray(myArray);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();
int[,] myArray3 = CreateMultipleArrays (myArray, myArray2);
Show2dArray(myArray3);
*/

/*
Задача 4. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
int[, ,] Create3dArray(int rows, int columns, int index)
{
    int[, ,] array = new int[rows, columns, index];
    int temp = 16;
    for(int i = 0, m = 0; i < rows; i++, m++)
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < index; k++)
            {
                array[i,j,k] = temp;
                temp = array[i,j,k] + 3;
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} [{i},{j},{k}] ");
            Console.WriteLine();
        }
}

Console.Write("Input a rows of array" + " ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a colums of array" + " ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a index of array" + " ");
int index = Convert.ToInt32(Console.ReadLine()); 

int[, ,] myArray = Create3dArray(rows, columns, index); 
Show3dArray(myArray); 
*/


