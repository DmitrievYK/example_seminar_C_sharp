// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[] AddArray(int[] array)
{
    Console.WriteLine("Введите длину массива ");
    int LengthArray = int
    return array;
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(i + j + " "); 
        }
        System.Console.WriteLine();
    }
}

int[,] array =  new int[3,4];

FillArray(array);