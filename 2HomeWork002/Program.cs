// Напишите программу, которая принимает на вход пятизначное число и проверят,
// является ли оно палиндромом.

// Проверка входящего числа на 5 цифр

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rev = num;
if (num >= 10000 && num <= 100000)
{
    int mirror = 0;
    while (rev !=0)
    {
        int digit = rev % 10;
        mirror = mirror * 10 + digit;
        rev /= 10;
    }
     
    if (mirror == num)
    {
        Console.WriteLine($"Число {num} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндром");
    }

}
else 
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}
