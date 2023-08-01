//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница
Console.WriteLine("Введите первое число ");
string input1 = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string input2 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
int number2 = Convert.ToInt32(input2);

int result_number2 = number2 * number2;

if (number1 == result_number2)
{
    Console.WriteLine("Да, является ");
}
else
{
    Console.WriteLine("Нет, является ");
}
