// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int row = 4;
int columns = 4;

int[,] FillMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[] SearchMinElement(int[,] matrix) // поиск минимального элемента c индексом строки и столбца
{
    int minElem = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElem)
            {
                minElem = matrix[i, j]; // минимальный элемент
                minRow = i; // индекс строки минимального элемента
                minColumn = j; // индекс столбца минимального элемента
            }
        }
    }
    Console.WriteLine($"минимальный элемент -> {minElem}, стр {minRow} стол {minColumn}.");
    int[] resultElemRowColumn = {minElem, minRow, minColumn}; 
    return resultElemRowColumn;
}

int[,] DeleteRowAndColumns(int[,] matrix, int[] minElem)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int newRow = 0;
    int newColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == minElem[1]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minElem[2]) continue;
            newMatrix[newRow, newColumn] = matrix[i, j];
            newColumn++; // увеличиваем индекс столбца чтобы правильно расположить элементы в укороченной матрице
        }
        newRow++; // увеличиваем индекс строки чтобы правильно расположить элементы после копирования в укороченной матрице
        newColumn = 0; // устанавливаем индекс столбца на 0, чтобы мы могли начать копирование элементов из следующей строки исходной матрицы
    }
    return newMatrix;
}


int[,] matrix = FillMatrix(row, columns);

PrintMatrix(matrix);
int[] minElem = SearchMinElement(matrix);
Console.WriteLine("[" + String.Join(", ", minElem) + "]");

int[,] newMatrix = DeleteRowAndColumns(matrix, minElem);
PrintMatrix(newMatrix);
