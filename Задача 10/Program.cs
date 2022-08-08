// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99 & N < 1000)
{
    string W = Convert.ToString(N);
    Console.WriteLine(W[1]); 
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
