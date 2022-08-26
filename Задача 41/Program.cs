// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
    

Console.WriteLine("Сколько будет чисел? ");
int size = Convert.ToInt32(Console.ReadLine());
PositiveNumbersArray(size);

int PositiveNumbersArray(int size)
{
    int count = 0;
    int[] numbers = new int[size];
    Console.WriteLine("Введите числa ");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());

        if (numbers[i] > 0)
        {
            count += 1; 
        }    
    }
    Console.WriteLine($"[{string.Join(", ", numbers)}]");
    Console.WriteLine($"Положительных чисел: {count}");
    return count;
}
