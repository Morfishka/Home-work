// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum = 0;
while (Number > 0){
    int N = Number % 10;
    Number = Number / 10;
    sum += N;
}   
Console.WriteLine($"Сумма цифр в числе = {sum}");

