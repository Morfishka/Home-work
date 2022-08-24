// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] arr = FillArrayWithRandomNumbers(123, 1, 500);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int countElements = ElementsInArray(arr, 10, 100);
Console.WriteLine($"Количество элементов массива, входящих в искомый интервал = {countElements}");


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange){
    int[] array = new int[size];

    Random random = new Random();
    for(int i = 0; i < size; i++){
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

int ElementsInArray(int[] array, int leftRange, int rightRange)
{   int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= leftRange & arr[i] <= rightRange)
        {
            count++;
        }
    }
    return count;
}