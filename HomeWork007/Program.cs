// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
switch(number)
{
    case 1:
    Console.WriteLine("Пн - работаем");
    break;

    case 2:
    Console.WriteLine("Вт - работаем");
    break;

    case 3:
    Console.WriteLine("Ср - работаем");
    break;

    case 4:
    Console.WriteLine("Чт - работаем");
    break;

    case 5:
    Console.WriteLine("Пт - работаем");
    break;

    case 6:
    Console.WriteLine("Сб - Ура, отдыхаем");
    break;

    case 7:
    Console.WriteLine("Вск - Ура, отдыхаем");
    break;

    default:
    Console.WriteLine("Нет такого дня недели");
    break;
}