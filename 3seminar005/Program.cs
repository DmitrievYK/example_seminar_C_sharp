﻿// Вычисление расстояния между взятыми на плоскости двумя точками А(хА; уА) и В(хВ; уВ), 
// выполняется по формуле d = √((хА – хВ)2 + (уА – уВ)2)

// Math.Pow(число которое возводим в степень, значение степени)
// Math.Sqrt (число) - взятие квадратного корня из числа

// https://github.com/zamotin-aa/C-examples

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);

// double d = Math.Pow((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)), 0.5);

// double d = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));

double d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2); //с округлением вверх

// static double myRound(double d, int precision)
// {
//     return ((int)(d * Math.Pow(10.0, precision)) / Math.Pow(10.0, precision));
// }

Console.WriteLine(d);

