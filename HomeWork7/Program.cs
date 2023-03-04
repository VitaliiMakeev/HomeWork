/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
void FillArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double tmp = Math.Round(new Random().NextDouble(), 2);
            array[i, j] = Math.Round(tmp * (10 + 20) - 10, 2);
        }
}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, cols];
FillArrayDouble(array);
PrintArrayDouble(array);
*/
/*
Задача 50. Напишите программу, которая на вход принимает значение 
элемента в двумерном массиве, и возвращает позицию этого элемента или же 
указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
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
string ElArraySorch(int[,] array, int num)
{
    string result = $"{num} -> Такого элемена нет в массиве!";
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
                result = $"Позиция элемента в массиве.\nСтрока: {i}\nСтолбик: {j}";
        }
    return result;
}
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
string SumArrayCols(int[,] array)
{
    string result = "";
    int i = 0;
    int j = 0;
    double tmp = Convert.ToDouble(array.GetLength(0));
    double[] tmparr = new double[array.GetLength(1)];
    while (i < array.GetLength(1))
    {
        while (j < array.GetLength(0))
        {
            tmparr[i] += array[j, i] / tmp;
            j++;
        }
        j = 0;
        i++;
    }
    result = $"Среднее арифметическое каждого столбца:{string.Join(", ", tmparr)}.";
    return result;
}
*/
/*
Задача HARD SORT необязательная. Считается за три обязательных
Задайте двумерный массив из целых чисел. Количество строк и столбцов 
задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
Например, задан массив:
1 4 7 2
5 9 10 3
После сортировки
1 2 3 4
5 7 9 10
*/
/*
int[,] ArraySort(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int[] tmp = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp[k] = array[i, j];
            k++;
        }
    }
    int temp = 0;
    for (int write = 0; write < tmp.Length; write++)
    {
        for (int sort = 0; sort < tmp.Length - 1; sort++)
        {
            if (tmp[sort] > tmp[sort + 1])
            {
                temp = tmp[sort + 1];
                tmp[sort + 1] = tmp[sort];
                tmp[sort] = temp;
            }
        }
    }
    int n = 0;
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = tmp[n];
            n++;
        }
    return result;
}
*/

int[,] ArrayShuphl(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int[] tmp = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp[k] = array[i, j];
            k++;
        }
    }
    int d = 0;
    while (d < tmp.Length / 2)
    {
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            int j = i + 1;
            int tmp2 = tmp[j];
            tmp[j] = tmp[i];
            tmp[i] = tmp2;
        }
        d++;
    }
    int n = 0;
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = tmp[n];
            n++;
        }
    return result;
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(ArrayShuphl(array));




