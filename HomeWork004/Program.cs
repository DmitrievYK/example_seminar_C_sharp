// Задача №8 Напишите программу, коотрая на вход принимает число N , а на выходе показывает все четные числа 
// от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num_stop = Convert.ToInt32(Console.ReadLine());
int num_start = 0;
Console.WriteLine(); // разделительная пустая строка

while (num_start < num_stop)
{
    num_start++;
    if (num_start % 2 == 0)
    {
        Console.WriteLine(num_start);
    }
}