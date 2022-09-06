// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] Array2D = {{1, 6, 7, 2,}, {5, 9, 2, 3}, {8, 3, 2, 4},{5, 1, 9, 6}};
Console.WriteLine("Исходный массив: ");
PrintMatrix(Array2D);
Console.WriteLine("Отсортированный массив: ");
SortingMatrix(Array2D);

int[,] SortingMatrix(int[,] matrix)
{
    int[][] arrays = new int[matrix.GetLength(0)][];

    for(int i = 0;  i < matrix.GetLength(0); i++)
    {
        int[] RowArray = new int[matrix.GetLength(1)];
        for(int j = 0;  j < matrix.GetLength(1); j++)
        { 
           RowArray[j] = matrix[i,j];
        }
        arrays[i] = RowArray;
        Array.Sort(RowArray);
        Console.WriteLine($"|{string.Join(" ", RowArray)}|");
    }
    
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}