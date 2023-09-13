// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int row = 4;
int columns = 4;

void PrintMatrix(int[,] matrix)
{
    string result = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " \t");
        }
        Console.WriteLine();
    }
}

int[,] ConstructSpiralMatrix(int row, int columns)
{
    int start = 1; // Заполнение начнем с 1
    int[,] spiralMatrix = new int[row, columns];
    int startX = 0; 
    int startY = 0; 
    int endX = columns - 1; // Остановка заполнения, с учетом индекса матрицы
    int endY = row - 1; // Остановка заполнения, с учетом индекса матрицы

    while (startX <= endX && startY <= endY)
    {
        // Заполнение верхней строки
        for (int i = startX; i <= endX; i++)
        {
            spiralMatrix[startY, i] = start++;
        }
        startY++; // для шага вниз через i 
        // Заполнение правого столбца
        for (int i = startY; i <= endY; i++)
        {
            spiralMatrix[i, endX] = start++;
        }
        endX--; // для шага влево через i
        // Заполнение нижней строки
        for (int i = endX; i >= startX; i--)
        {
            spiralMatrix[endY, i] = start++;
        }
        endY--; // для шага вверх через i
        // Заполнение левого столбца
        for (int i = endY; i >= startY; i--)
        {
            spiralMatrix[i, startX] = start++;
        }
        startX++; // для шага вправо через i
    }
    return spiralMatrix;
}

int[,] matrix = ConstructSpiralMatrix(row, columns);
PrintMatrix(matrix);