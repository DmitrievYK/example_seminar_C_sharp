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
    Console.WriteLine("Пн - нет");
    break;

    case 2:
    Console.WriteLine("Вт - нет");
    break;

    case 3:
    Console.WriteLine("Ср - нет");
    break;

    case 4:
    Console.WriteLine("Чт - нет");
    break;

    case 5:
    Console.WriteLine("Пт - нет");
    break;

    case 6:
    Console.WriteLine("Сб - Да");
    break;

    case 7:
    Console.WriteLine("Вск - Да");
    break;

    default:
    Console.WriteLine("Введите число от 1 до 7");
    break;
}