// l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2+ (z 2 - z 1) 2)
//AB = √(xb - xa)2 + (yb - ya)2

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Убрать 
// Console.WriteLine("Введите координаты А ");
// int[] array_A = new int[2];
// array_A[0] = x;
// array_A[1] = y;
// Console.WriteLine("Введите координаты х и y: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Введите координаты Б : ");
// int[] array_B = new int[2];
// array_B[0] = x;
// array_B[1] = y;
// Console.WriteLine("Введите координаты х и y: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
Console.WriteLine("Введите абсиссу первой точки: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату первой точки: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите абсиссу второй точки: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату второй  точки: ");
int by = Convert.ToInt32(Console.ReadLine());

double d = 0;
d = Math.Round(Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay)), 2);

// Console.WriteLine($"Расстояние между заданными точками равно: {d:N2}");
Console.WriteLine($"Расстояние между заданными точками равно: {d}");