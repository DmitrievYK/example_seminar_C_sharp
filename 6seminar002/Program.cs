// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int numberA = Print("Введите число:");
int numberB = Print("Введите число:");
int numberC = Print("Введите число:");

void TriangleTheorem(int numberA, int numberB, int numberC)
{
    if(numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberB + numberA)
    {
       Console.WriteLine("Треугольник с длинами сторон A, B и C существует");
    }
    else
    {
        Console.WriteLine("Треугольника с такими сторонами не существует");
    }
}

TriangleTheorem(numberA, numberB, numberC);