//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Array2D ={{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4},{5, 2, 6, 7}};
PrintMatrix(Array2D);
RowWithMinimumSum(Array2D);

void RowWithMinimumSum(int[,] matrix)
{
    int MinSum = 0; 
    int index = 0;

    for(int i = 0;  i < matrix.GetLength(0); i++)
    {
        int Sum = 0;
        for(int j = 0;  j < matrix.GetLength(1); j++)
        { 
           Sum += matrix[i,j]; 
        }
        if (i == 0)
        {
            MinSum = Sum;
        }
        else if (Sum < MinSum)
        {
            MinSum = Sum;
            index = i;
        }     
    }
    Console.WriteLine($" Минимальная сумма [{MinSum}] найдена в строке {index + 1}.");
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