// Напишите программу, которая принимает на вход три числа и выдает максимальное 
// из этих чисел.
// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число a =: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b =: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c =: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if ((a <= c) && (b <= c))
{
    Console.WriteLine("Max = " + c);
}
else if ((a <= b) && (c <= b))
{
    Console.WriteLine("Max = " + b);
}
else if ((a >= b) && (c <= a))
{
    Console.WriteLine("Max = " + a);
}