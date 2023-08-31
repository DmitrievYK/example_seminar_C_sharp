// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = new int[4];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(String.Join(" ", array));
}

FillArray(array);
int[] transform(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
    return array;
}
transform(array);
Console.WriteLine(String.Join(" ", array));

