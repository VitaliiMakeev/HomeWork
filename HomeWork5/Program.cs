/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
*/
/*
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}
*/
/*
string EvenNum(int[] array)
{
    string result = String.Empty;
    int i = 0;
    foreach (var el in array)
    {
        if (el % 2 == 0)
            i++;
    }
    result = $"[{string.Join(", ", array)}] -> {i}";
    return result;
}


int[] array1 = new int[5];
FillArray(array1);
Console.WriteLine(EvenNum(array1));
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
string SumNum(int[] array)
{
    string result = String.Empty;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    result = $"[{string.Join(", ", array)}] -> {sum}";
    return result;
}
int[] array2 = new int[5];
FillArray(array2);
Console.WriteLine(SumNum(array2));
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
string DiffNum(int[] array)
{
    string result = String.Empty;
    int max = array[0];
    int min = array[0];
    foreach (var el in array)
    {
        if (el > max) max = el;
    }
    foreach (var el in array)
    {
        if (el < min) min = el;
    }
    result = $"[{string.Join(", ", array)}] - > {max - min}";
    return result;
}


int[] array4 = new int[5];
FillArray(array4);
Console.WriteLine(DiffNum(array4));
*/
/*
Задача 30: - HARD необязательная Напишите программу, которая на вход получает 
размерность массива. Далее заполняет его случайными уникальными числами и выводит 
на экран. Далее производим сортировку массива от большего к меньшему и выводим 
на экран. Далее придумываем алгоритм перемешивания списка на основе случайности , 
применяем этот алгоритм и выводим на экран результат. Встроенные методы работы с 
массивами использовать нельзя.
*/

void ArrayShaflRandom(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    Console.WriteLine($"[{string.Join(", ", array)}] - Создали новый массив");
    for (int k = 0; k < array.Length; k++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int tmp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = tmp;
            }
        }
    }
    Console.WriteLine($"[{string.Join(", ", array)}] - Отсортировали массив");
    for (int f = array.Length - 1; f >= 1; f--)
    {
        int h = new Random().Next(f + 1);
        int tmp = array[h];
        array[h] = array[f];
        array[f] = tmp;
    }
    Console.WriteLine($"[{string.Join(", ", array)}] - Перемешали массив");
}
ArrayShaflRandom(5);



