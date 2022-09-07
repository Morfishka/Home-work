// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] Get3DMatrix(int x, int y, int z, int leftRange, int rightRange)
{
    int[,,] matrix = new int[x, y, z];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = rand.Next(leftRange, rightRange);
                } 
        }
    }
    return matrix;
 }

 void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("{0}" , matrix[i, j, k]);
                Console.Write($"({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] Matrix3D = Get3DMatrix(3,3,3, 10, 99);
PrintMatrix(Matrix3D);