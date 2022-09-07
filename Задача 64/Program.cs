﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите минимальное значение: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumbersInTheInterval(int M, int N)
{
    if (N < M)
    {
        int t = N;
        N = M;
        M = t;
        Console.WriteLine($"Числа от {M} до {N}:");
        
    }
    for (int i = M; i <= N; i++)
    {
        Console.Write($"{i} "); 
    }
}

NumbersInTheInterval(M,N);