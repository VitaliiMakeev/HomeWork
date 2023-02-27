
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.Write("Введите числа через запятую: ");
string numb = Console.ReadLine();
string[] numbers = numb.Split(", ");
int count = 0;
foreach (var el in numbers)
{
    try
    {
        int num = Convert.ToInt32(el);
        if (num > 0) count++;
    }
    catch
    {
        Console.WriteLine($"Вы ввели {el}, но мы продолжим считать!");
    }
}

Console.WriteLine($"{numb} -> {count}");
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.Write($"Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// k1 * x + b1 = k2 * x + b2
// k1 * x = k2 * x + b2 - b1
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
string Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    string result = $"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})";
    return result;
}

string res = Intersection(b1, k1, b2, k2);

Console.Write(res);
*/
/*
Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, 
в том числе для отрицательных индексов.
*Пример:*
- для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
*/
/*
string NegaFibonnachi(int num)
{
    string result = "";
    int[] array = new int[num + 1];
    array[0] = 0;
    array[1] = 1;
    array[2] = 1;
    for (int i = 3; i < num + 1; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    int[] array2 = new int[num * 2 + 1];
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (i % 2 == 0)
        {
            if (i >= array2.Length / 2)
            {
                array2[i] = array[count];
                count++;
            }
            else
                array2[i] = -array[num - i];
        }
        else
        {
            if (i >= array2.Length / 2)
            {
                array2[i] = array[count];
                count++;
            }
            else
                array2[i] = array[num - i];
        }
    }
    result = $" - для k = 8 список будет выглядеть так: [{string.Join(" ", array2)}]";
    return result;
}


Console.WriteLine(NegaFibonnachi(8));
*/
/*
задача 40 - HARD необязательная. На вход программы подаются три целых 
положительных числа. Определить , является ли это сторонами треугольника. 
Если да, то вывести всю информацию по нему - площадь, периметр, значения углов 
треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
*/
string Triumf(double a, double b, double c)
{
    string result = "Не может!";
    string tmp1 = "Не равносторонний.";
    string tmp2 = "Не равнобедренный.";
    string tmp3 = "Не прямоугольный треугольник.";
    double sqer = 0.0;
    double p = 0.0;
    double corner1 = 0.0;
    double corner2 = 0.0;
    double corner3 = 0.0;

    double max = a;
    if (a + b >= c && a + c >= b && b + c >= a)
    {
        if (max < b) max = b;
        else if (max < c) max = c;
        if (a == b && a == c) tmp1 = "Является равносторонним!";
        if (a == b || a == c || b == c) tmp2 = "Является равнобедренным!";
        p = (a + b + c) / 2;
        sqer = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        corner1 = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
        corner2 = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
        corner3 = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
        if (corner1 == 90 || corner2 == 90 || corner3 == 90) tmp3 = "Прямоугольный треугольник!";
        result = $"Может! Его площадь - {Math.Round(sqer, 2)}\nЕго периметр - {a + b + c}\nЕго углы: {Math.Round(corner1, 3)}, {Math.Round(corner2, 3)}, {Math.Round(corner3, 3)}\n{tmp1}\n{tmp2}\n{tmp3}";
    }
    return result;
}
Console.Write("Введите первую сторону треугольника: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
double number3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Triumf(number1, number2, number3));
