// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray() // метод заполняющий массив рандомным числами от 1 до 8, с именем аргумента collection
{
    int[] array = new int[8]; // длинна равная длинне массива с именем аргумента collection
    for (int index = 0; index < array.Length; index ++)
    {
        array[index] = new Random().Next(0, 2); 
    }
    return array;
}
void Print(int[] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        Console.WriteLine(array[index] + " ");
    }
}
Print(FillArray());

// Второй вариант
// int[] ConstrutArray(int arrayLenght){
//     int[] array = new int[arrayLenght];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0,2);
//     }
//     return array;
// }
// void Print(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }
// Print(ConstrutArray(8));



// // Вывод массива из 8 элементов, сост из 0 и 1 в случайном порядке

// int[]array = new int[8];

// void fillArray(int[] array){
//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         array[index] = new Random().Next(0,2);
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }

// fillArray(array);


// Вывод массива на печать варианты

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// foreach (int element in array) {
//     Console.Write(element + " ");
// }
// Console.WriteLine();
// string arrayOutput = String.Join(", ", array);
// Console.WriteLine("[" + arrayOutput + "]");
