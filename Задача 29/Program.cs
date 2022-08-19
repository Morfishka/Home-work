// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.


int[] array = new int[8];
for (int i = 0; i < array.Length; i++){
    Console.Write("Введите число ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"[{string.Join(", ", array)}]");
