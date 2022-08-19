// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
double result = A;
int i = 1; 
if (B == 0){
   Console.WriteLine($"Число {A} в степени {B} = 1"); 
}
else if (B < 0){
    B = Math.Abs(B);
    while (i < B)
    {
        result *= A;
        i++;
    }
    Console.WriteLine($"Число {A} в степени -{B} = {1/result:f4}");
}
else{
    while (i < B)
    {
        result *= A;
        i++;
    }
    Console.WriteLine($"Число {A} в степени {B} = {result}");
}
