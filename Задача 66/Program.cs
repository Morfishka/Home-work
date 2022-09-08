// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите минимальное значение: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int N = Convert.ToInt32(Console.ReadLine());

 if (N < M)
    {int t = N; N = M; M = t;}

int SumOfNumbers(int M, int N)
{
    int i = M;
    if (i == N) return M;
    else return i + SumOfNumbers(M + 1, N);
}

Console.WriteLine($"Сумма чисел в интервале от {M} до {N} равна {SumOfNumbers(M,N)}");