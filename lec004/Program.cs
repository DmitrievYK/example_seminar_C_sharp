// упорядочить массив 6 8 3 2 1 4 5 7

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // метод печатающий массив пробегающий по каждому элементу
{
    int count = array.Length;

    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        //поиск минимального элемента
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            minPosition = j;
        }
        //Смена позиции найденного элемента с минимальным (СВАП)
        int temporary = array[i];
        array[i] = array[minPosition]; //Смена позиции найденного элемента с минимальным
        array[minPosition] = temporary; //Смена позиции найденного элемента с минимальным
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);