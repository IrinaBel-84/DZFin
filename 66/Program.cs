﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < m)
{
    int t = n;
    n = m;
    m = t;
}

int Rec(int m, int n)
{
    int sum = m;
    if (m == n)
    {
        return n;
    }
    else
    {
        sum = sum + Rec(m + 1, n);
        return sum;
       
    }
}
Console.Write(Rec(m, n) ); 