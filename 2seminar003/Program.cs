// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число ");
string input1 = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string input2 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
int number2 = Convert.ToInt32(input2);

int result_number2 = number2 * number2;

if (number1 == result_number2 || number2 == number1 * number1)
{
    Console.WriteLine("Да, является ");
}
else
{
    Console.WriteLine("Нет, является ");
}