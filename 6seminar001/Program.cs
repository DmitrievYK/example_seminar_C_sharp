// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// 1. перевернуть массив
// 2. создать новый перевернутый массив

// void Reverse (int[] array)
// {
//     int tmp;
//     for (int i = 0; i < array.Length/2; i++) //  array.Length/2 - сокращает количество операций в два раза или обратно перевернем весь массив в исходное состояние
//     {
//         // Последовательность операций
//         // [0,1,2,3,4]
//         // [4,1,2,3,0]
//         // [4,3,2,1,0]
//         tmp = array[i];
//         array[i] = array[array.Length - 1 - i]; // позиция array[array.Length - 1 - i] справой стороны
//         array[array.Length - 1 - i] = tmp; // используем новую переменную так как array[i] перезаписан
//     }
// }


void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    } 
}

void Reverse (int[] array)
{
    int tmp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}


// переворот массива
public static int[] ReverseArray(int[] arr)
{
int length = arr.Length;
int[] reversedArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        reversedArray[i] = arr[length - i - 1];
    }

return reversedArray;
}