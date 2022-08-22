//6.-----------------------------------------------------------------------------------------------------------

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
/*

int[] CreateArray(int size)
{
   
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
       Console.Write($"введите {i+1} число из 5 цифр:  ");
       newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }
    return count;    

}

int [] array = CreateArray(5);

Console.WriteLine($"Из введеных чисел больше 0: {Count(array)}");

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

//y = k1 * x + b1, y = k2 * x + b2; 

//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

//2 = k1 * 0 + b1

//2 = k2 * 0 + b2

Console.Write("Input value b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x =(b2-b1)/(k1-k2);
double y = k1 * x + b1;

Console.Write($"Сoordinates of the intersection point: {x}; {y} ");



 //7. ---------------------------------------------------------------------------------------------------

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


/*double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(),1);
        }

    }

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // вывод первой строки
    {
        for (int j = 0; j < array.GetLength(1); j++)// вывод первого столбца
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m, n, min, max);


Show2dArray(array);

*/





/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4


17 -> такого числа в массиве нет
*/
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }

    return newArray;
}

void ShowElement(int[,] array, int rows, int colums)
{



    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (i == rows && j == colums)
                Console.Write(array[i, j]);



        }
        
    }
    if ( rows > array.GetLength(0) || colums > array.GetLength(1))
                Console.Write($"Элемент с индексами {rows},{colums} не найден");

    Console.WriteLine();
}



Console.Write("Input minValue of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue of element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(r, c, min, max);

Console.WriteLine();

Console.Write("Input index found number of rows: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index found number of colums: ");
int j = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // вывод первой строки
    {
        for (int j = 0; j < array.GetLength(1); j++)// вывод первого столбца
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Show2dArray(array);
ShowElement(array, i, j);


*/





/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }

    return newArray;
}

void MiddleAr(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)};\t");
    }
}

Console.Write("Input minValue of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue of element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(r, c, min, max);

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // вывод первой строки
    {
        for (int j = 0; j < array.GetLength(1); j++)// вывод первого столбца
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Show2dArray(array);

MiddleAr(array);
*/





//9.  -------------------------------------------------------------------------------------------------------------------

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Summa(int a, int b)
{
    if (b != a) return b + Summa(a, b - 1);
    return a;
}
Console.Write("Input number m: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n: ");
int b = Convert.ToInt32(Console.ReadLine());



Console.Write($"{Summa(a, b)}");
*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29

int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akerman(n - 1, 1);
    if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
    return Akerman(n, m);
}

Console.Write("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{Akerman(n, m)}");

