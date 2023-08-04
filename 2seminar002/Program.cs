// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(99, 1000);
Console.WriteLine(number);

int a = number / 100;
int b = number % 10;

string s1 = a.ToString();
string s2 = b.ToString();
string result = s1 + s2;
Console.WriteLine(result);

