// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int mul(int number)
{
    int result =  1;
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;

}
int number = Print("Введите число");
Console.WriteLine(mul(number));