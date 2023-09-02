// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    Console.Write("[" + String.Join(", ", array) + "]");
    Console.WriteLine();
    return array;
}
FillArray(array);

int SumElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
Console.WriteLine($"Сумма нечетных элементов массива -> {SumElementsArray(array)}");