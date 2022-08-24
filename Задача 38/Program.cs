// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayWithRandomDoubleNumbers(int size, double leftRange, double rightRange){
    double[] array = new double[size];

    Random random = new Random();
    for(int i = 0; i < size; i++){
        array[i] = Math.Round(random.NextDouble(), 4);
    }
    return array;
}

double[] arr = FillArrayWithRandomDoubleNumbers(5, 1, 11);
Console.WriteLine($"[{string.Join(", ", arr)}]");

double max = arr[0];
double min = arr[0];

 for(int i = 0; i < arr.Length; i++)
 {
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
 }
 double result = max - min;
 Console.WriteLine($"{max} - {min} = {result}");
// Console.WriteLine($"разница между максимальным и минимальным элементом массива = {result}");