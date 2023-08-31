// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа которая считает сумму цифр в числе");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lenNumber = DefineLength(number);

int DefineLength(int lenNumber)
{
    int i = 0;
    while (lenNumber > 0)
    {
        lenNumber /= 10; // Аналогично lenNumber = lenNumber / 10;
        i++; // считаем количество цифр в числе
    }
    return i;
}

int NumberSum(int number, int Length)
{
    int sum = 0;
    for (int i = 0; i < Length; i++)
    {
        sum += number % 10; //Аналогично sum = sum + (number % 10);
        number /= 10; //Аналогично number = number/ 10;
    }
    Console.WriteLine();  
    return sum;
}

Console.WriteLine($"Сумма чисел в числе {number} равна: {NumberSum(number, lenNumber)}");
