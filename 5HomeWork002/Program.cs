// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа которая находит пересечания двух прямых, по k-угловому коэффициенту и b-свободному коэффициенту");

double[] pointA = new double[2];
double[] pointB = new double[2];

double[] SetFunctionNumber(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i <= 0)
        {
            Console.Write($"Введите угловой коэффициент k: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.Write($"Введите свободный коэффициент b: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    return array;
}

void LineIntersectionCoordinates(double[] pointA, double[] pointB)
{
    if (pointA[0] == pointB[0] && pointA[1] == pointB[1])
    {
        Console.WriteLine("Прямые лежат на одной прямой");
    }
    else if (pointA[0] == pointB[0])
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double[] result = new double[2];
        for (int i = 0; i < result.Length; i++)
        {
            if (i <= 0)
            {
                result[i] = (pointA[1] - pointB[1]) / (pointB[0] - pointA[0]); ;
            }
            else
            {
                result[i] = pointB[0] * ((pointA[1] - pointB[1]) / (pointB[0] - pointA[0])) + pointB[1];
            }
        }
        Console.WriteLine("Точка пересечения двух прямых -> [" + String.Join(", ", result) + "]");
    }
    
}
SetFunctionNumber(pointA);
SetFunctionNumber(pointB);
LineIntersectionCoordinates(pointA, pointB);