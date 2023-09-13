// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// void PrintNumber(int n, int m)
// {
//     for (; n <= m; n++)
//     {
//         Console.Write(n + " ");
//     }
// }
//  int n = 1, m = 5;
//  PrintNumber(n, m);

 // Рекурсия
 void PrintNumber(int n, int m)
{
    if (n == m)
    {
        Console.Write(n);
        return;
    }
    Console.Write(n + ", ");
    PrintNumber(++n , m); // PrintNumber (n + 1, m);
    // Array[n] для массива
    // PrintNumber(++n , m)
}
 PrintNumber(1, 5);

// от преподавателя 
 void PrintNumber(int n, int m)
{
    if (n == m) {
        Console.Write(n);
        return;
    }
    Console.Write(n + ", ");
    PrintNumber(n + 1, m);
}

PrintNumber(1, 5);

