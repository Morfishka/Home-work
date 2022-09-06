//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2    и   1 5 8 5
// 5 9 2 3        4 9 4 2
// 8 4 2 4        7 2 2 6
// 5 2 6 7        2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] Array1 ={{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4},{5, 2, 6, 7}};
// int[,] Array1 ={{1, 4, 7},{5, 9, 2},{8, 4, 2},{5, 2, 6}};
// int[,] Array1 ={{1, 4, 7},{5, 9, 2},{8, 4, 2}};
int[,] Array2 ={{1, 5, 8, 5},{4, 9, 4, 2},{7, 2, 2, 6},{2, 3, 4, 7}};
// int[,] Array2 ={{1, 5, 8},{4, 9, 4},{7, 2, 2},{2, 3, 4}};
// int[,] Array2 ={{1, 5, 8},{4, 9, 4},{7, 2, 2}};

Console.WriteLine("Первая матрица: ");
PrintMatrix(Array1);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(Array2);
Console.WriteLine("Результат: ");
int[,] Result = ProductOfTwoMatrices(Array1,Array2);
PrintMatrix(Result);

int[,] ProductOfTwoMatrices(int[,] matrix1, int[,] matrix2)
{
            if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
                Console.WriteLine("Форма матриц не согласована. Умножение невозможно.");
                int[,] ResultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix2.GetLength(1); ++j)
                {
                      ResultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return ResultMatrix;
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