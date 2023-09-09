// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] array = new int[4, 4];

void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 90);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SwitchRowsCols(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    if (rows == cols) // Проверяем, можно ли заменить строки на столбцы
    {
        int[,] result = new int[rows, cols]; // Создаем новый массив для хранения результата
        for (int i = 0; i < rows; i++) // Заменяем строки на столбцы
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = array[j, i];
            }
        }

        Console.WriteLine("Массив после замены строк на столбцы:");  // Выводим результат на экран
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        // Выводим сообщение для пользователя
        Console.WriteLine("Замена строк на столбцы невозможна, так как массив не квадратный.");
    }
}


FillArray(array);
SwitchRowsCols(array);

// Второй вариант решения

// int[,] array = new int[4, 5];

// int[,] FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,] array2 = FillArray(array);

// Console.WriteLine("---------------");


// void PrintArray(int[,] array){
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Невозможно перевернуть массив");
//     }
//     else
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array2);

// Вариант 3

// int[,] AddArray()
// {
//     Console.WriteLine("Введите длину массива ");
//     int lengthArray = int.Parse(Console.ReadLine());
//     int getArray = int.Parse(Console.ReadLine());
//     int[,] array = new int[lengthArray, getArray];
//     return array;
// }

// int[,] array = AddArray();

// if (array.GetLength(0) != array.GetLength(1)){
//     Console.WriteLine("Невозможно перевернуть массив");
// } else {

// int[,] FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,] array2 = FillArray(array);

// Console.WriteLine("-------------------------");

// void FillArray21(int[,] arr)
// {
//     for(int i=0; i< arr.GetLength(0)-1; i++) {
//             for(int j=i+1; j< arr.GetLength(1); j++) {
//                 int temp = arr[i,j];
//                 arr[i,j] = arr[j,i];
//                 arr[j,i] = temp;
//     }
//     Console.WriteLine();
//     }
// }

// FillArray21(array2);

// void PrintArray(int[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array2);

// }
