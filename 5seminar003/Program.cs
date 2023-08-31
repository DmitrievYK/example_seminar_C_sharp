// // Задача 33: Задайте массив. Напишите программу, которая определяет, 
// // присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, -3] -> да

// Вариант 1

// int[] array = new int[5];
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// void proverka(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (num == array[i])
//         {
//             Console.WriteLine("Да"); // return true
//         }
//         else
//         {
//             Console.WriteLine("Нет"); 
//         }
//     }
// }
// FillArray(array);
// proverka(array, num);

// вариант 2
int[] array = new int[4];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
    Console.WriteLine(String.Join(" ", array));
}
FillArray(array);
int final = 0;
int number = Convert.ToInt32(Console.ReadLine());

void metod(int[] array){
    for( int i = 0; i < array.Length; i ++){
        
        if(array[i] == number){
            
            final = 1;
        }
    }
    if(final == 1){
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Нет");
    }
}
metod(array);

// Вариант 3

// int[] array = new int[5];
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// void proverka(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (num == array[i])
//         {
//             return true;
//         }
//     }
//     return false;
// }
// FillArray(array);
// proverka(array, num);

