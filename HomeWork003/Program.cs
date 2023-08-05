// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делитья ли оно на две без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Проверка на чет/нечет - Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}