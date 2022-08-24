// Задача 34: Задайте массив, заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = FillArrayWithRandomNumbers(7, 100, 1000);
Console.WriteLine(string.Join(", ", arr));
int count = 0;
for (int i = 0; i < arr.Length; i++){
    if (arr[i] % 2 == 0){
        count += 1;
    }
}
Console.WriteLine($" количество четных чисел в массиве = {count}");


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange){
    int[] array = new int[size];

    Random random = new Random();
    for(int i = 0; i < size; i++){
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}