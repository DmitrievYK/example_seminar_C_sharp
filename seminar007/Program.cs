// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

/*Console.WriteLine("Введите трехзначное число ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

// for (int x = 0; i < 5; i++) 
// {

// }

if (number >=100 && number <1000)
{
    int mid = (number % 100 - number % 10) / 10;
}
else
System.Console.WriteLine("Это число не трехзначное"); */


Console.WriteLine("Введите целое число");
int input1 = Convert.ToInt32(Console.ReadLine());
if (input1 > 100 && input1 < 999)
{
int input2 = input1 % 100; 
int input3 = input2 % 10;
Console.WriteLine(input3);
}
else
{
    Console.WriteLine("Ошибка");
}