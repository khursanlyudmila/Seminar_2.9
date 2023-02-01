/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string NumberRec(int a, int n)
{
    if (a >= n) return $"{a } " + NumberRec(a - 1, n);
    else return String.Empty;
}

Console.WriteLine(NumberRec(8, 1));
