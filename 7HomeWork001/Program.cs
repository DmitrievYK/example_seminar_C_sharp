// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] matrixA = {{2, 4}, {3, 4}};
// int[,] matrixB = {{3, 2}, {3, 3}}; 
int[,] matrixA = {{2, 4, 1}, {1, 3, 7}, {8, 3, 5}};
int[,] matrixB = {{3, 4, 3}, {2, 2, 6}, {5, 2, 7}}; 


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
 
int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultMatrix.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

Console.WriteLine("Результирующая матрица: ");
PrintMatrix(MultiplicationMatrix(matrixA, matrixB));
