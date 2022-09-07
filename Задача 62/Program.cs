// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.WriteLine("Введите размер матрицы: ");
int Size = Convert.ToInt32(Console.ReadLine());

int[,] SpiralMatrix = CreateSpiralMatrix(Size);
PrintMatrix(SpiralMatrix);


int[,] CreateSpiralMatrix(int Size)
{
    int step = 1;
    int i = 0;
    int j = 0;
    int[,] matrix = new int[Size, Size];

    while (step <= Size * Size)
    {
        matrix[i, j] = step;
        step++;

        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1){
            j++;
        }
        else if (i < j && i + j >= matrix.GetLength(0) - 1){
            i++;   
        }
        else if (i >= j && i + j > matrix.GetLength(1) - 1){
            j--;   
        }
        else{
            i--;   
        }
        
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