// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (num >= 100)
{
    string tusk = num.ToString();
    Console.WriteLine(tusk[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}