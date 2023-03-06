/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}
/*
int[,] ArraySortRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }
    return array;
}
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/
/*
string ArraySumMin(int[,] array)
{
    int[] temp = new int[array.GetLength(0)];
    string res = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[i] += array[i, j];
        }
    }
    int min = temp[0];
    foreach (var el in temp)
    {
        if (el < min) min = el;
    }
    for (int i = 0; i < temp.Length; i++)
    {
        if (min == temp[i]) res = $"{i + 1} строка";
    }
    return res;
}
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] ArrayMulty(int[,] array, int[,] array2)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                result[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return result;
}
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
void FillArrayThree(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArrayThree(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],3}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] SpiralArrayNumber(int number)
{
    int[,] result = new int[number, number];
    int n = number;
    int m = number;
    int kol = 1;
    int t = 0;
    int j = 0;
    int n1 = number;
    int m1 = number;

    while (kol <= n1 * m1)
    {
        for (int i = t; i < n; i++)
            result[j, i] = kol++;
        j = n - 1;
        for (int i = t + 1; i < m; i++)
            result[i, j] = kol++;
        j = m - 1;
        for (int i = n - 2; i >= t; i--)
            result[j, i] = kol++;
        j = t;
        for (int i = m - 2; i > t; i--)
            result[i, j] = kol++;
        n--;
        m--;
        t++;
        j = t;
    }
    return result;
}






// return result;

// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество еще чего-то");
// int cols2 = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// int[,] array = { { 2, 4 }, { 3, 2 } };
// int[,] array2 = { { 3, 4 }, { 3, 3 } };
PrintArray(SpiralArrayNumber(5));
// Console.WriteLine(gor1);
// Console.WriteLine(vert1);
// Console.WriteLine(vert);



