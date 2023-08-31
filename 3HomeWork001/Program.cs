// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// функция принимающая число
int adopt(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int extentnumber(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 2; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;

}
int A = adopt("Введите число А: ");
int B = adopt("Введите число В (степень): ");
Console.WriteLine($"Результат расчетов: {extentnumber(A, B)}");
