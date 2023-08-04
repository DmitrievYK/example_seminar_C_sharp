// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if ((firstNumber % a == 0) && (firstNumber % b == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}