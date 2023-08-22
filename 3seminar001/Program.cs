// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// 1 Ввод X и Y
// 2 определить четверть, основываясь на X и Y
// 3 

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{x}, {y}");

// if (x > 0 && y >0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
Console.WriteLine("Введите х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{x}, {y}");
// Введение массива как пример из двух цифр
// int[] array = new int[2];
// array[0] = x;
// array[1] = y;
// Console.WriteLine("Введите координаты х и y: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвёртая четверть");
}
else
{
    Console.WriteLine("x = 0, y = 0");
}