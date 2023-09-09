// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива),
//  а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

int[,] GetMatrixLength()
{
    Console.WriteLine("Введите колчество строк: ");
    int arrayLine = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите колчество столбцов: ");
    int arrayColumn = int.Parse(Console.ReadLine());
    int[,] matrix = new int[arrayLine, arrayColumn];
    return matrix;
}
int GetMatrixLimit(string text)
{
    Console.WriteLine(text);
    int matrixLimit = Convert.ToInt32(Console.ReadLine());
    return matrixLimit;
}

void CreateRandomMatrix(int[,] matrix, int minLimitRandom, int maxLimitRandom)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minLimitRandom, maxLimitRandom);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int[,] matrix = GetMatrixLength();
int minLimitRandom = GetMatrixLimit("Введите Min значение рандомных чисел границы матрицы: ");
int maxLimitRandom = GetMatrixLimit("Введите Max значение рандомных чисел границы матрицы: ");
Console.WriteLine();
CreateRandomMatrix(matrix, minLimitRandom, maxLimitRandom);
