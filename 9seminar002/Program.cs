// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SumNumber(int n)
{
    if (n == 0) 
    {
        // Console.Write(sum);
        return 0;
    }
    return n % 10 + SumNumber(n / 10);
}
Console.WriteLine(SumNumber(453));

// Второй вариант решения

// static int SumDigit(int n)
// {
//     // базовый случай - число состоит из одной цифры
//     if (n < 10)
//     {
//         return n;
//     }
//     // рекурсивный случай - число состоит из 2 и более цифр
//     else
//     {
//         return n % 10 + SumDigit(n / 10);
//     }
// }
// int n = 15526;
// Console.WriteLine("Сумма цирф {0} равна {1}", n, SumDigit(n));

//  Третий вариант

// int SumNumber(int n)
// {
//     if (n < 10) 
//     {
//         // Console.Write(sum);
//         return n;
//     }
    
//     return n % 10 + SumNumber(n / 10);
// }

// Console.WriteLine(SumNumber(453));



