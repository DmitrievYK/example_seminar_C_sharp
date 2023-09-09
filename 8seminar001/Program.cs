// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetMatrixLength()
{
    Console.WriteLine("Введите колчество строк: ");
    int arrayLine = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите колчество столбцов: ");
    int arrayColumn = int.Parse(Console.ReadLine());
    int[,] matrix = new int[arrayLine, arrayColumn];
    return matrix;
}
void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetChangeLineAndColumn(int[,] matrix)
{
    int[] contMatrix = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        contMatrix[j] = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = contMatrix[j];
    }
    // for (int j = 0; j < matrix.GetLength(1); j++)
    // {
    //     matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];

    // }
    // for (int j = 0; j < matrix.GetLength(1); j++)
    // {
    //     matrix[matrix.GetLength(0) - 1, j] = contMatrix[j];

    // }
 

}
void PrintArray(int[,] array) // метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrixLength();
FillArray(matrix);
Console.WriteLine();
GetChangeLineAndColumn(matrix);
PrintArray(matrix);

//  Второй вариант
// int[,] array = new int[5, 5];

// void FillArray(int[,] array) //метод заполнения массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10, 90);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] array) // метод печати массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SwitchRows(int[,] array) // метод замены строк в массиве
// {

//     int rows = array.GetLength(0); // Получаем количество строк и столбцов
//     int cols = array.GetLength(1);

//     int[] temp = new int[cols]; // Создаем временный массив для хранения первой строки

//     for (int j = 0; j < cols; j++) // Копируем первую строку во временный массив
//     {
//         temp[j] = array[0, j];
//     }

//     for (int j = 0; j < cols; j++) // Копируем последнюю строку в первую
//     {
//         array[0, j] = array[rows - 1, j];
//     }

//     for (int j = 0; j < cols; j++) // Копируем временный массив в последнюю строку
//     {
//         array[rows - 1, j] = temp[j];
//     }
// }

// FillArray(array);
// SwitchRows(array);
// Console.WriteLine("Новый массив ниже");
// PrintArray(array);