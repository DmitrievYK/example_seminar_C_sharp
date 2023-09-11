// Задача № 52
int n = 4;
int m = 5;
int k = 3;
void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    // Введите свое решение ниже
    int[,] matrix = new int[n, m];
    int start = 1; // Начинаем с 1 и прибавляем k
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = start;
            start += k;
        }
    }
    return matrix;
}
// double[] FindAverageInColumns(int[,] matrix)
// {
//     // Введите свое решение ниже
//     double[] averege = new double[matrix.GetLength(1)];
//     int sumNumber = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             // averege[j] += double.Parse($"{matrix[i, j]}" / matrix.GetLength(0));
//             //averege[j] += matrix[i, j];
//             sumNumber += matrix[i, j];                                    
//         }
//         averege[j] = Convert.ToDouble(sumNumber / matrix.GetLength(0));
//     }
//     //averege[j] = Convert.ToDouble(averege[j]);
//     Console.WriteLine("[" + String.Join(", ", averege) + "]");
//     return averege;
// }
double[] FindAverageInColumns(int[,] matrix)
{
    // Введите свое решение нижe
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sumNumber = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumNumber += matrix[i, j];
        }
        average[j] = Convert.ToDouble(sumNumber) / matrix.GetLength(0);
    }
    //Console.WriteLine("[" + String.Join(", ", average) + "]");
    return average;

}

void PrintListAvr(double[] average)
{
    Console.WriteLine($"The averages in columns are: ");
    for (int i = 0; i < average.Length; i++)
    {

        Console.Write("{0:0.00} \t", average[i]);
    }
}
PrintArray(CreateIncreasingMatrix(n, m, k));
FindAverageInColumns(CreateIncreasingMatrix(n, m, k));
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintListAvr(FindAverageInColumns(result));