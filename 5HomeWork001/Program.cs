// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = new int[5];

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива № {i + 1} из 5: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    return array;
}

int HowMuchNumbersIsPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
Console.WriteLine($"Пользователь ввел {HowMuchNumbersIsPositive(array)} чисел больше нуля");



