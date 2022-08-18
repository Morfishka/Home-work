// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
string W = Convert.ToString(N);

if (W.Length == 5)
{
    if(W[0] == W[4] & W[1] == W[3]){
        Console.WriteLine("Да, это палиндромом");
    }
    else{
        Console.WriteLine("Нет");
    }
}
else{
     Console.WriteLine("Не пятизначное число");
}