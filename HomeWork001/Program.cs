// Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, а какое меньше
Console.WriteLine("Введите число a =: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b =: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (num1 > num2)
{
    Console.WriteLine("a = " + num1 );
    Console.WriteLine("b = " + num2 );
    Console.WriteLine("MAX = " + num1 );
}
if (num1 < num2)
{
    Console.WriteLine("a = " + num1 );
    Console.WriteLine("b = " + num2 );
    Console.WriteLine("MAX = " + num2 );
}
else if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}