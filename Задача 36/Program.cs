// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange){
    int[] array = new int[size];

    Random random = new Random();
    for(int i = 0; i < size; i++){
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] array = FillArrayWithRandomNumbers(5, -10, 11);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();
int sum = 0;
for(int i = 0; i < array.Length; i += 2){
    sum += array[i];
}
Console.WriteLine($" Сумма нечетных элементов в массиве = {sum}");