// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36



// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum += i; // sum = sum + i;

// }

// Console.WriteLine(sum);

// number - A
// от 1 до number
// i = 0; i +1 ... number; i = 1, 2 , 3 , 4 , 5 .... number

// 1. Ввод  числа
// 2. И поиск суммы

int Parse(string text) // при указании типа функции (int, string) она и будет выдавать этот тип уже на выходе
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// int - тип возвращаемого значения
// Parse - произвольное название функции
// () - Аргументы для работы функции
// {} - Тело функции
// return - возвращаемое значение

// string text = "Введите число";
// Parse(text);

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
        {
            sum += i; // sum = sum + i;

        }
        return sum;
}
int number = Parse("Введите число");
int sum = Sum(number);
Console.WriteLine("Итоговая сумма " + sum);