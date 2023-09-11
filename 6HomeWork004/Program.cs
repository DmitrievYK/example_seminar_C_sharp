// Проверка на коде от Платформы ГБ задачи №50
using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
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

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
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

    public static int[] FindNumberByPosition(int[,] result, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] number = new int[2];
        if (rowPosition >= 0 && rowPosition < result.GetLength(0) && columnPosition >= 0 && columnPosition < result.GetLength(1))
        {
            number[0] = result[rowPosition - 1, columnPosition - 1];
            number[1] = 0;
            return number;
        }
        else
        {
            return new int[2];
        }


    }

    public static void PrintCheckIfError(int[] result, int x, int y)
    {
        // Введите свое решение ниже
        if (result[0] != 0 && result[1] == 0)
        {
            Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
        }
        else Console.WriteLine("There is no such index");
    }


    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3; // (3) (4)
            m = 4; // (4) (5)
            k = 2; // (2) (3)
            x = 8; // (8) (2)
            y = 3; // (3) (2)
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}


// Решение с платформы задачи №50
// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//     public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
//     {  
//         int [] number={0,-1};
//         if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
//         {
//             number[1]=0;
//             number[0]=matrix[rowPosition-1,columnPosition-1];
//             return number;
//         }
//         return number;
//     }

//     public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//         if (results[1]==-1){Console.WriteLine("There is no such index");}
//         else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//            x = 2;
//            y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }