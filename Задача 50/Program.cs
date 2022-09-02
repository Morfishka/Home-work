// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.WriteLine("Введите строку ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix2D = {{1, 4, 7, 2,}, {5, 9, 2, 3}, {8, 4, 2, 4}};

// PrintMatrix(matrix2D);
// Console.WriteLine();
SearchingElementInMatrix(matrix2D, m, n);

void SearchingElementInMatrix(int[,] matrix, int m, int n)
{
if (m < 0 | m >= matrix.GetLength(0) | n < 0 | n >= matrix.GetLength(1))
            {
                Console.WriteLine("Такого элемента в матрице нет.");
            }

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == m & j == n)
            {
                Console.WriteLine($"На позиции [{m},{n}] находится число: {matrix[i,j]}");
            }
        }
    }
}

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0} ", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
// }