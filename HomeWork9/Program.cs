/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Hello, World!");
*/
/*
string ListNum(int n)
{
    if (n == 0) return "";
    return $"{n}, " + $"{ListNum(n - 1)}";
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ListNum(number));
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNum(int m, int n)
{
    if (m == n) return n;
    return m + SumNum(m + 1, n);
}

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(number, number1));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));

}
Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {number}, n = {number1} -> A(m,n) = {Akkerman(number, number1)}");
