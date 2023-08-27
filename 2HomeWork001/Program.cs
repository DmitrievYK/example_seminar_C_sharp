// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3Д пространстве.
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// метод для ввода координат точек, выполненый через массив с выводом на экран

void ReadAndPrintPointArray(int[] array)
{
    int count = array.Length;
    for (int i = 1; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Вы ввели координаты точки: x = {array[0]}, y = {array[1]}, z = {array[2]}");
}

Console.WriteLine("Введите координаты точки А");
int[] pointA = new int[3];
ReadAndPrintPointArray(pointA);

Console.WriteLine("Введите координаты точки B");
int[] pointB = new int[3];
ReadAndPrintPointArray(pointB);

// метод по расчету расстояния между точек с округлением
void DistanceBetweenPoints(int[] arrayA, int[] arrayB)
{
    Console.WriteLine("Результат расчета:");
    double result = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
    Console.WriteLine($"Без округления = {result}");
    Console.WriteLine($"Округление до сотых = {result:F2}");
}
DistanceBetweenPoints(pointA, pointB);