// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] array = new int[5];
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.WriteLine(String.Join(", ", array));
}

FillArray(array);

int[] NewCopyArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i];
    }
    // array[2] = 43;
    Console.WriteLine(String.Join(", ", newarray));
    // Console.WriteLine(String.Join(", ", array));
    return newarray;
}
NewCopyArray(array);