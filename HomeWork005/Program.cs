// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


if (num >= 100 && num <= 1000)
{
    // int a = (num / 10) % 10;
    // Console.WriteLine(a);
    Console.WriteLine((num / 10) % 10);
}
else
{
    Console.WriteLine("Ошибка числа");
}
