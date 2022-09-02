// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.


int[,] matrix2D = {{1, 14, 3, 21,}, {15, 9, 12, 3}, {4, 7, 2, 6}};
ArithmeticMeanElementsInColumn(matrix2D);

void ArithmeticMeanElementsInColumn(int[,] matrix)
{
    
    Console.WriteLine("Среднее арифметическое в столбцах: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.Write("({0:0.0}) ", sum/matrix.GetLength(0));
    }
}