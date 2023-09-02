// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];

double[] FillArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(0, 100) + rand.NextDouble(), 2);
    }
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    return array;
}
FillArray(array);

double DiffMaxMinNum(double[] array)
{
    double maxNum = array.Max();
    double minNum = array.Min();
    double result = Math.Round(maxNum - minNum, 2);
    return result;
}
Console.WriteLine($"Разница между макс и мин элементами массива -> {DiffMaxMinNum(array)}");// test new vscode and gits
