//адача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите число от 1 до 7 ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number == 1)
{
    Console.WriteLine("понедельник");
}
if (number == 2)
{
    Console.WriteLine("вторник");
}
if (number == 3)
{
    Console.WriteLine("среда");
}
if (number == 4)
{
    Console.WriteLine("четвер");
}
if (number == 5)
{
    Console.WriteLine("пятница");
}
if (number == 6)
{
    Console.WriteLine("суббота");
}
if (number == 7)
{
    Console.WriteLine("воскресенье");
}
if (number > 7 && number < 1)
{
    Console.WriteLine("Введите значение от 1 до 7");
}